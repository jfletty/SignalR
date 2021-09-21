# SignalR

Overview
----------------
The project consists of a SignalR demo that allows instant communication between two .NET 5 console applications.


Running it Locally?
----------------
### Dependencies
You will need the IDE of your choice to run the server and will need .NET 5 runtime install.

### Running it
1. Open your IDE and start the SignalR.Server project. This will use localhost:5000 to run the server required for the communication.
2. Open the `bin/Debug/net5.0` folder for the SignalR.Client and run the `SignalR.Client.exe` file. 
3. Enter your client name (e.g client1) and wait.
4. Open up a secondary `SignalR.Client.exe` file and enter a different client name.
5. Thats it, now when you type into either of the clients, the message will instantly appear on the other client.
