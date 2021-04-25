using System.Threading.Tasks;
using Grpc.Core;

namespace VbRoslynService.Services
{
    public interface ITesterService
    {
        Task<TestResponse> HealthTest(TestRequest req, ServerCallContext context);
    }
}