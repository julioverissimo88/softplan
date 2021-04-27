using api_calculo.Domain.Interfaces;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace api_calculo.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private readonly IJurosClientService _serviceHttp;
        public CalculaJurosService(IJurosClientService serviceHttp)
        {
            _serviceHttp = serviceHttp;
        }

        public async Task<decimal> JurosCompostos(int valorinicial, int meses)
        {
            double taxa = await _serviceHttp.Get();
            var teste = valorinicial * (1 + taxa);
            var result = Double.Parse(teste.ToString(), CultureInfo.InvariantCulture);
            var finishResult = Math.Pow(result, meses);
            return ((decimal)finishResult);
        }
    }
}
