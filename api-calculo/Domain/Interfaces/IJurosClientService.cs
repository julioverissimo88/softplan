using System.Threading.Tasks;

namespace api_calculo.Domain.Interfaces
{
    public interface IJurosClientService
    {
        Task<double> Get();
    }
}
