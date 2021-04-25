using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace VbRoslynService.Services
{
    public class AnalysisLoader : IAnalysisLoader
    {
        public AnalysisLoader()
        {
            this.CurrentWorkspace = null;
        }

        public Workspace CurrentWorkspace { get; }

        public Task LoadProject(string project, CancellationToken cancel)
        {
            cancel.ThrowIfCancellationRequested();
            return Task.CompletedTask;
        }
    }
}