using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Producer;
using NuGet.Protocol.Core.Types;
using SistemaDeCadastroAPI.Repositorios.Intefaces;
using System.Text;

namespace SistemaDeCadastroAPI.Repositorios
{
    public class EventHub : IEventHub
    {
        public async Task CreateEventAsync()
        {
            string connectionString = "Endpoint=sb://firsteventhubb.servicebus.windows.net/;SharedAccessKeyName=sharedAcessConect;";
            string eventHubName = "demoeventhub";

            EventHubProducerClient producer = new EventHubProducerClient(connectionString,eventHubName);

            List<EventData> eventData = new List <EventData>();
            eventData.Add(new EventData("Novo usuário registrado teste"));

             await producer.SendAsync(eventData);

            


        }
}
}
