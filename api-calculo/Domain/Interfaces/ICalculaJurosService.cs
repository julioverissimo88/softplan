using System.Threading.Tasks;

namespace api_calculo.Domain.Interfaces
{
    public interface ICalculaJurosService
    {
        Task<decimal> JurosCompostos(double valorinicial, int meses);
    }
}
