using System;
using Microsoft.AspNetCore.SignalR.Client;

namespace SignalR.Client
{
    class Program
    {
        private static bool ShouldClose;
        private static string User;

        private static void Main(string[] args)
        {
            var connection = new HubConnectionBuilder().WithUrl("https://localhost:5001/chatHub").Build();
            connection.StartAsync().Wait();
            
            Console.WriteLine("Enter your name...");
            User = Console.ReadLine();
            
            Console.WriteLine("Waiting for messages");
            Console.WriteLine("Enter your message and press 'Enter' to send it");

            while (!ShouldClose)
            {
                // Read Messages
                connection.On<string, string>("ReceiveMessage",
                    (user, message) =>
                    {
                        if (user != User)
                        {
                            Console.WriteLine(user + " says `" + message + "`");
                        }
                    });

                // Write Messages
                var inputMessage = Console.ReadLine();
           
                connection.InvokeAsync("SendMessage", User, inputMessage);


                // Exit App
                if (Console.ReadKey(true).Key == ConsoleKey.Home)
                {
                    ShouldClose = true;
                }
            }
        }
    }
}