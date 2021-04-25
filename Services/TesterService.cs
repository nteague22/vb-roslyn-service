using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace VbRoslynService.Services
{
    public class TesterService : Tester.TesterBase, ITesterService
    {
        private readonly ILogger<TesterService> _logger;

        public TesterService(ILogger<TesterService> logger)
        {
            this._logger = logger;
        }

        public override Task<TestResponse> HealthTest(TestRequest req, ServerCallContext context)
        {
            return Task.FromResult<TestResponse>(new TestResponse()
            {
                Details = "Test check for empty call"
            });
        }
    }
}