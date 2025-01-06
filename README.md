# Bank Queue Management Application

This repository contains the **Bank Queue Management Application**, a client-server application that manages a bank's customer queue. The system consists of two projects:

1. **BankQueueAPI**: A server-side API that handles business logic, queue management, and client-server communication.
2. **BankQueueApp**: A client-side application with interfaces for tellers and customers, built as a Windows Forms application.

## Features

### Client-Side Application (BankQueueApp)
- **Teller Interface**:
  - View and manage the queue.
  - Call, skip, or mark customers as served.
  - Display the current serving customer.
- **Customer Display Interface**:
  - Show the queue status and the currently serving customer.
- **Kiosk Interface**:
  - Customers can take a queue number by selecting a service type.
- Real-time synchronization of queue status across all interfaces using SignalR.

### Server-Side API (BankQueueAPI)
- RESTful endpoints for queue management.
- SignalR hub for real-time communication.
- HTTPS and HTTP support.

### Prerequisites
- [.NET 6.0 SDK](https://dotnet.microsoft.com/)
- Visual Studio (2022 or later recommended)
- SQL Server (optional if a database is configured)

**Interfaces**:
   - Tellers can manage the queue.
   - Customers can take a queue number from the kiosk.
   - The display shows real-time updates of queue status.
