using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class EmailLog
{
    public int Id { get; set; }

    public string EmailAddress { get; set; } = null!;

    public string OtpCode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? DebugInfo { get; set; }

    public DateTime CreatedAt { get; set; }
}
