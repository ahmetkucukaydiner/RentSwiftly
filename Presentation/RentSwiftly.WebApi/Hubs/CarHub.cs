using Microsoft.AspNetCore.SignalR;

namespace RentSwiftly.WebApi.Hubs
{
    public class CarHub : Hub
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarHub(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task SendCarCount()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7000/api/statistics/getcarcount");
            var value = await responseMessage.Content.ReadAsStringAsync();
            await Clients.All.SendAsync("ReceiveCarCount", value);
        }
    }
}
