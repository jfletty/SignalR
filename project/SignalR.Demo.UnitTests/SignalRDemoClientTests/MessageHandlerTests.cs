using System;
using Microsoft.AspNetCore.SignalR.Client;
using SignalR.Demo.Client;
using Xunit;

namespace SignalR.Demo.UnitTests.SignalRDemoClientTests;

public class MessageHandlerTests
{
    [Fact]
    public void WhenHandleMessageReceivesNullConnection_ExceptionIsThrown()
    {
        // act & assert
        Assert.Throws<ArgumentNullException>(() => new MessageHandler(null));
    }
    
    [Fact]
    public void WhenHandleMessageReceivesConnection_ClassIsCreated()
    {
        // arrange
        var connection = new HubConnectionBuilder().WithUrl("https://localhost:5001/chatHub").Build();
        
        // act
        var exception = Record.Exception(() => new MessageHandler(connection));
        
        // assert
        Assert.Null(exception);
    }
}