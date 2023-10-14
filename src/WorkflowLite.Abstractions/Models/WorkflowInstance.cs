using System;

namespace WorkflowLite.Abstractions.Models;

public class WorkflowInstance
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public WorkflowStatus Status { get; set; }

    public WorkflowInstanceType InstanceType { get; set; }

    public string WorkflowDefinitionId { get; set; } = null!;

    public string WorkflowProcessId { get; set; }

    public string State { get; set; } = null!;

    public string CurrentActivity { get; set; }

    public string TenantId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastActivityTime { get; set; }
}
