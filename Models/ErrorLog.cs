using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class ErrorLog
{
    public int Id { get; set; }

    public string ErrorType { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? FileName { get; set; }

    public int? LineNumber { get; set; }

    public string? UserEmail { get; set; }

    public DateTime CreatedAt { get; set; }
}
