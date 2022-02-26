using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace SignalR.Demo.Client;

public class MessageHandler
{
    private readonly HubConnection _connection;
    private static bool ShouldClose;
    private static string User;

    public MessageHandler(HubConnection connection)
    {
        ArgumentNullException.ThrowIfNull(connection);
        _connection = connection;
    }

    public async Task HandleMessage()
    {
        await _connection.StartAsync();

        Console.WriteLine("Enter your name...");
        User = Console.ReadLine();

        Console.WriteLine("Waiting for messages");
        Console.WriteLine("Enter your message and press 'Enter' to send it");

        while (!ShouldClose)
        {
            // Read Messages
            _connection.On<string, string>("ReceiveMessage",
                (user, message) =>
                {
                    if (user != User)
                    {
                        Console.WriteLine($"{user} says `{message}`");
                    }
                });

            // Write Messages
            var inputMessage = Console.ReadLine();

            await _connection.InvokeAsync("SendMessage", User, inputMessage);


            // Exit App
            if (Console.ReadKey(true).Key == ConsoleKey.Home)
            {
                ShouldClose = true;
            }
        }
    }
}