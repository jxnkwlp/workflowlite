using System.Collections.Generic;

namespace WorkflowLite.Abstractions.Models;

public class WorkflowDefinition
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; }

    public WorkflowDefinitionSettings Settings { get; set; } = null!;

    public List<string> Commands { get; set; } = new List<string>();

    public List<string> Tags { get; set; } = new List<string>();

    public string TenantId { get; set; }

    public string DefaultFormName { get; set; }
}
