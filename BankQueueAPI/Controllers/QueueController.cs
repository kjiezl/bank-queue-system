using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Data.SQLite;
using System.Text.Json;

namespace BankQueueAPI.Controllers
{
    [ApiController]
    [Route("api/queue")]
    public class QueueController : ControllerBase
    {
        private readonly string _connectionString = "Data Source=queue.db;Version=3;";
        private readonly IHubContext<QueueHub> _hubContext;

        public QueueController(IHubContext<QueueHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpGet("status")]
        public IActionResult GetQueueStatus()
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            string query = "SELECT * FROM Queue WHERE Status = 'Waiting' ORDER BY Timestamp";
            using var command = new SQLiteCommand(query, connection);
            using var reader = command.ExecuteReader();
            var queue = new List<object>();
            while (reader.Read())
            {
                queue.Add(new
                {
                    Id = reader["Id"],
                    QueueNumber = reader["QueueNumber"],
                    ServiceType = reader["ServiceType"],
                    TellerNumber = reader["TellerNumber"],
                    Status = reader["Status"],
                    Timestamp = reader["Timestamp"]
                });
            }

            if (queue.Count == 0)
            {
                return Ok(new
                {
                    CurrentQueue = (object?)null,
                    QueueCount = 0,
                    WaitingQueue = queue
                });
            }

            return Ok(new
            {
                CurrentQueue = queue[0],
                QueueCount = queue.Count,
                WaitingQueue = queue
            });
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddToQueue([FromBody] JsonElement data)
        {
            try
            {
                if (!data.TryGetProperty("QueueNumber", out var queueNumberElement) || !data.TryGetProperty("ServiceType", out var serviceTypeElement))
                {
                    return BadRequest(new { Message = "QueueNumber or ServiceType is missing" });
                }

                string? queueNumber = queueNumberElement.GetString();
                string? serviceType = serviceTypeElement.GetString();

                using var connection = new SQLiteConnection(_connectionString);
                connection.Open();
                string query = "INSERT INTO Queue (QueueNumber, ServiceType, Status) VALUES (@QueueNumber, @ServiceType, 'Waiting')";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@QueueNumber", queueNumber);
                    command.Parameters.AddWithValue("@ServiceType", serviceType);
                    command.ExecuteNonQuery();
                }

                await _hubContext.Clients.All.SendAsync("QueueUpdated");

                return Ok(new { Message = "Added to queue successfully." });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return BadRequest(new { Message = "An error occurred while adding to the queue." });
            }
        }

        [HttpGet("forTeller")]
        public IActionResult GetQueueForTeller()
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            string query = "SELECT * FROM Queue WHERE Status NOT IN ('Served', 'Skipped') ORDER BY Timestamp;";
            using var command = new SQLiteCommand(query, connection);
            using var reader = command.ExecuteReader();
            var queue = new List<object>();
            while (reader.Read())
            {
                queue.Add(new
                {
                    Id = reader["Id"],
                    QueueNumber = reader["QueueNumber"],
                    ServiceType = reader["ServiceType"],
                    TellerNumber = reader["TellerNumber"] == DBNull.Value ? null : reader["TellerNumber"],
                    Status = reader["Status"],
                    Timestamp = reader["Timestamp"]
                });
            }
            return Ok(queue);
        }

        [HttpPost("callNext")]
        public async Task<IActionResult> CallNextCustomer([FromBody] JsonElement data)
        {
            try
            {
                if (!data.TryGetProperty("QueueNumber", out var queueNumberElement) || !data.TryGetProperty("TellerNumber", out var tellerNumberElement))
                {
                    return BadRequest(new { Message = "QueueNumber or TellerNumber is missing" });
                }

                string? queueNumber = queueNumberElement.GetString();
                string? tellerNumber = tellerNumberElement.GetString();

                using var connection = new SQLiteConnection(_connectionString);
                connection.Open();

                string query = "UPDATE Queue SET Status = 'In Service', TellerNumber = @TellerNumber WHERE QueueNumber = @QueueNumber AND Status = 'Waiting' LIMIT 1";
                using SQLiteCommand command = new(query, connection);
                command.Parameters.AddWithValue("@TellerNumber", tellerNumber);
                command.Parameters.AddWithValue("@QueueNumber", queueNumber);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    await _hubContext.Clients.All.SendAsync("QueueUpdated");

                    return Ok(new { Message = "Next customer called successfully." });
                }
                else
                {
                    return BadRequest(new { Message = "No rows were updated. Queue might already be in service or doesn't exist." });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return BadRequest(new { Message = "An error occurred while calling the next customer." });
            }
        }

        [HttpPost("markServed")]
        public async Task<IActionResult> MarkCustomerAsServed([FromBody] JsonElement data)
        {
            try
            {
                if (!data.TryGetProperty("QueueNumber", out var queueNumberElement))
                {
                    return BadRequest(new { Message = "QueueNumber is missing" });
                }

                string? queueNumber = queueNumberElement.GetString();

                using var connection = new SQLiteConnection(_connectionString);
                connection.Open();
                string query = "UPDATE Queue SET Status = 'Served' WHERE QueueNumber = @QueueNumber AND Status = 'In Service'";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@QueueNumber", queueNumber);
                    command.ExecuteNonQuery();
                }

                await _hubContext.Clients.All.SendAsync("QueueUpdated");

                return Ok(new { Message = "Customer marked as served." });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return BadRequest(new { Message = "An error occurred while marking the customer as served." });
            }
        }

        [HttpPost("skip")]
        public async Task<IActionResult> SkipCustomer([FromBody] JsonElement data)
        {
            try
            {
                if (!data.TryGetProperty("QueueNumber", out var queueNumberElement))
                {
                    return BadRequest(new { Message = "QueueNumber is missing" });
                }

                string? queueNumber = queueNumberElement.GetString();

                using var connection = new SQLiteConnection(_connectionString);
                connection.Open();
                string query = "UPDATE Queue SET Status = 'Skipped' WHERE QueueNumber = @QueueNumber AND Status = 'Waiting'";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@QueueNumber", queueNumber);
                    command.ExecuteNonQuery();
                }

                await _hubContext.Clients.All.SendAsync("QueueUpdated");

                return Ok(new { Message = "Customer skipped successfully." });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return BadRequest(new { Message = "An error occurred while skipping the customer." });
            }
        }
    }
}