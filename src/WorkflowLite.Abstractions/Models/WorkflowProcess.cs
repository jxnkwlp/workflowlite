using System.Collections.Generic;

namespace WorkflowLite.Abstractions.Models;

public class WorkflowProcess
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; }

    public string WorkflowDefinitionId { get; set; } = null!;

    public string DefaultFormName { get; set; }

    public List<WorkflowProcessState> States { get; set; } = new List<WorkflowProcessState>();
}
