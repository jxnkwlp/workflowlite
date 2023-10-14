using System.Threading.Tasks;

namespace WorkflowLite.Abstractions.Models;

public interface IActivity
{
    string Name { get; }

    ValueTask ExectuteAsync(IActivityExecutionContext context);
}
