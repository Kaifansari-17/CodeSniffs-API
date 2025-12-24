using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class AdminUser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string? Permissions { get; set; }

    public DateTime? LastLogin { get; set; }

    public string? LastLoginIp { get; set; }

    public DateTime? LockUntil { get; set; }

    public int FailedLoginAttempts { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
