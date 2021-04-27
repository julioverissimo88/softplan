using api_calculo.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace api_calculo.Infra.Services
{
    public class JurosClientHttpService : IJurosClientService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;
        private readonly string _route;

        public JurosClientHttpService(HttpClient client, IConfiguration config)
        {
            this._config = config;
            this._client = client;
            this._route = "juros/taxaJuros";
        }

        public async Task<double> Get()
        {
            HttpResponseMessage response = await _client.GetAsync(_route);
            string responseRequest = await response.Content.ReadAsStringAsync();
            double taxa = Double.Parse(responseRequest, CultureInfo.InvariantCulture);
            return taxa;
        }
    }
}
