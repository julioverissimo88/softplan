using api_calculo.Domain.Interfaces;
using System;
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

        public async Task<decimal> JurosCompostos(double valorinicial, int meses)
        {
            double taxa = await _serviceHttp.Get();
            decimal finishResult = Convert.ToDecimal(Math.Pow((valorinicial * (1 + taxa)), meses));
            return finishResult;
        }
    }
}
