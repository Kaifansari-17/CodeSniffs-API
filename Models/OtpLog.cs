using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class OtpLog
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Otp { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
