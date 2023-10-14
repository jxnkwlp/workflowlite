namespace WorkflowLite.Abstractions.Models;

public class WorkflowProcessState
{
    public string StateName { get; set; } = null!;
    public string[] RoleNames { get; set; } = null!;
    public string[] UserIds { get; set; } = null!;
    public string FormName { get; set; }
}
