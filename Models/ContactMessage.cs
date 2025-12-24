using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class ContactMessage
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string Subject { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? Attachments { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Status { get; set; } = null!;
}
