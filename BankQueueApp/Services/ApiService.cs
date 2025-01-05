using BankQueueApp;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

public class ApiService
{
    private static readonly HttpClient _client = new HttpClient();
    private readonly string _baseUrl = "https://localhost:7096/api/queue";

    public async Task<QueueData> GetQueueDataAsync()
    {
        try
        {
            var response = await _client.GetAsync($"{_baseUrl}/status");
            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();
            //Console.WriteLine("Raw JSON Response: " + responseData);
            responseData = responseData.Replace("\"tellerNumber\":{}", "\"tellerNumber\":null");

            var queueData = JsonConvert.DeserializeObject<QueueData>(responseData);

            return queueData;
        }
        catch (Exception ex)
        {
            throw new Exception($"Error fetching queue data: {ex.Message}");
        }
    }

    public async Task<bool> AddQueueAsync(string queueNumber, string serviceType)
    {
        try
        {
            var queueItem = new
            {
                QueueNumber = queueNumber,
                ServiceType = serviceType
            };

            var content = new StringContent(JsonConvert.SerializeObject(queueItem), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync($"{_baseUrl}/add", content);
            response.EnsureSuccessStatusCode();

            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Error adding queue: {ex.Message}");
        }
    }

    public async Task<List<QueueItem>> GetQueueForTellerAsync()
    {
        try
        {
            var response = await _client.GetAsync($"{_baseUrl}/forTeller");
            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();

            var queueData = JsonConvert.DeserializeObject<List<QueueItem>>(responseData);

            return queueData;
        }
        catch (Exception ex)
        {
            throw new Exception($"Error fetching queue for teller: {ex.Message}");
        }
    }

    public async Task<bool> CallNextAsync(object data)
    {
        var jsonData = JsonConvert.SerializeObject(data);
        Console.WriteLine($"Sending Data: {JsonConvert.SerializeObject(data)}");
        var response = await _client.PostAsync($"{_baseUrl}/callNext", new StringContent(jsonData, Encoding.UTF8, "application/json"));

        if (response.IsSuccessStatusCode)
        {
            return true;
        }
        else
        {
            string errorMessage = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"API Error: {errorMessage}");
            return false;
        }
    }

    public async Task<bool> MarkAsServedAsync(string queueNumber)
    {
        try
        {
            var content = new StringContent(JsonConvert.SerializeObject(new { QueueNumber = queueNumber }), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync($"{_baseUrl}/markServed", content);
            response.EnsureSuccessStatusCode();

            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Error marking as served: {ex.Message}");
        }
    }

    public async Task<bool> SkipCustomerAsync(string queueNumber)
    {
        try
        {
            var content = new StringContent(JsonConvert.SerializeObject(new { QueueNumber = queueNumber }), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync($"{_baseUrl}/skip", content);
            response.EnsureSuccessStatusCode();

            return true;
        }
        catch (Exception ex)
        {
            throw new Exception($"Error skipping customer: {ex.Message}");
        }
    }
}