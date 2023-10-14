using System.Collections.Generic;

namespace WorkflowLite.Abstractions.Models;

public class WorkflowInstanceLog
{
    public string Id { get; set; } = null!;
    public string ActivityId { get; set; } = null!;
    public Dictionary<string, object> Data { get; set; } = null!;
}
