using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class EmailVerification
{
    public string Email { get; set; } = null!;

    public string Otp { get; set; } = null!;

    public DateTime ExpiresAt { get; set; }

    public bool Verified { get; set; }
}
