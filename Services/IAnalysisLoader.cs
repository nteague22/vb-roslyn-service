using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace VbRoslynService.Services
{
    public interface IAnalysisLoader
    {
        Task LoadProject(string project, CancellationToken cancel);

        Workspace CurrentWorkspace { get; }
    }
}