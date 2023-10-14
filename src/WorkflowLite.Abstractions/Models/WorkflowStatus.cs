namespace WorkflowLite.Abstractions.Models;

public enum WorkflowStatus
{
    Initialized = 0,
    Running = 1,
    Idled = 2,
    Finalized = 3,
    Terminated = 4,
    Error = 5,
    Unknown = 6,
}
