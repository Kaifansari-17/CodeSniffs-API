using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string? ContactNumber { get; set; }

    public string PasswordHash { get; set; } = null!;

    public string? Country { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int FailedLoginAttempts { get; set; }

    public DateTime? LockUntil { get; set; }

    public DateTime? PasswordChangedAt { get; set; }

    public DateTime? LastLoginAt { get; set; }

    public string? PasswordResetToken { get; set; }

    public DateTime? PasswordResetExpires { get; set; }

    public string? TwoFactorSecret { get; set; }

    public bool IsVerified { get; set; }

    public string? VerificationToken { get; set; }

    public DateTime? TokenExpires { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public string? PhoneEncrypted { get; set; }

    public string? PhoneIv { get; set; }

    public string? EmergencyContact { get; set; }

    public string? EmergencyContactIv { get; set; }

    public string? ResetToken { get; set; }

    public DateTime? ResetTokenExpires { get; set; }
}
