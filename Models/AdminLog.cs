using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class AdminLog
{
    public int Id { get; set; }

    public int? AdminId { get; set; }

    public string Action { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public DateTime CreatedAt { get; set; }
}
