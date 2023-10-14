using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace WorkflowLite.Abstractions;

public interface IWorkflowManager
{
    Task StartAsync(string definitionId, int version, Dictionary<string, object> input = null, CancellationToken cancellationToken = default);
}

public interface IWorkflowRunner
{
}
