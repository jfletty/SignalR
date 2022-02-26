# SignalR Demo
This is a DotNet 6 example of SignalR that allows instant communication between two .NET 6 console applications.

The solution isn't intended to be an entire working project but more a starting point to build from.

## Build With
- [DotNet 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [SignalR.Client](https://docs.microsoft.com/en-us/aspnet/core/signalr/dotnet-client?view=aspnetcore-6.0&tabs=visual-studio)

## Getting Started

### Prerequisites
This solution is fairly basic so will only require an IDE and .net runtime+SDK installed on your computer.

### Installation

1. Open your IDE and start the SignalR.Server project. This will use localhost:5000 to run the server required for the communication.
2. Open the `bin/Debug/net6.0` folder for the SignalR.Client and run the `SignalR.Client.exe` file. 
3. Enter your client name (e.g client1) and wait.
4. Open up a secondary `SignalR.Client.exe` file and enter a different client name.
5. Thats it, now when you type into either of the clients, the message will instantly appear on the other client.

### Contribution Guide
This repo is open for any additional changes, improvements or alterations. When you are making these changes, follow the coding conventions documented on the [Microsoft website](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions).

Any changes should be completed in your own fork and then PR'ed into the master branch.

## Roadmap

- [ ] Add Changelog
- [ ] Add unit tests
- [ ] Add component tests

## Contact
Name: Josh Fletcher

Email: [10fletcherjosh@gmail.com](mailto:10fletcherjosh@gmail.com)

Socials: [Linkedin](https://www.linkedin.com/in/joshua-fletcher-ab4521b8/)
