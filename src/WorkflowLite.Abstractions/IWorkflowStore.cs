using System.Threading;
using System.Threading.Tasks;
using WorkflowLite.Abstractions.Models;

namespace WorkflowLite.Abstractions;

public interface IWorkflowStore
{
    Task<WorkflowDefinition> GetDefinitionAsync(string id, int version, CancellationToken cancellationToken = default);
}
