using System.Threading.Tasks;

namespace WorkflowLite.Abstractions.Models;

public abstract class Activity : IActivity
{
    public abstract string Name { get; }

    public string Description { get; set; }

    public int RetryCount { get; set; }

    public abstract ValueTask ExectuteAsync(IActivityExecutionContext context);
}
