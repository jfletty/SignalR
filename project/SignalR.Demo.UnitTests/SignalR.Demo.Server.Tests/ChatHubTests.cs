using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Moq;
using SignalR.Demo.Server;
using Xunit;

namespace SignalR.Demo.UnitTests.SignalR.Demo.Server.Tests;

public class ChatHubTests
{
    [Fact]
    public async Task WhenChatHubInitialises_InitialMessageIsSent()
    {
        // arrange
        var mockClients = new Mock<IHubCallerClients>();
        var mockClientProxy = new Mock<IClientProxy>();
 
        mockClients.Setup(clients => clients.All).Returns(mockClientProxy.Object);
 
 
        var simpleHub = new ChatHub
        {
            Clients = mockClients.Object
        };
 
        // act
        await simpleHub.StartupMessage();
 
 
        // assert
        mockClients.Verify(clients => clients.All, Times.Once);
 
        mockClientProxy.Verify(
            clientProxy => clientProxy.SendCoreAsync(
                "Server started and ready to receive",
                It.IsAny<object[]>(),
                default),
            Times.Once);
    }
    
}