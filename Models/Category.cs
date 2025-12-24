using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NameKey { get; set; }

    public string? Description { get; set; }

    public string IconClass { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string? Image { get; set; }

    public string? BannerText { get; set; }

    public int SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string Status { get; set; } = null!;
}
