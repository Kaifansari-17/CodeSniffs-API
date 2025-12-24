using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class SignupLog
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? ContactNumber { get; set; }

    public string? Country { get; set; }

    public string? PasswordHash { get; set; }

    public bool OtpSent { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
