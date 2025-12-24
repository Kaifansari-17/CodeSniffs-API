using System;
using System.Collections.Generic;

namespace CodeSniffs.API.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NameKey { get; set; }

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public string? DescriptionKey { get; set; }

    public string? Image { get; set; }

    public string? ImageUrl { get; set; }

    public string? Document { get; set; }

    public string? DocumentUrl { get; set; }

    public int? FileSize { get; set; }

    public string? FileType { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? CategoryId { get; set; }

    public string? Period { get; set; }

    public string? Note { get; set; }

    public bool IsPopular { get; set; }

    public string? BadgeText { get; set; }

    public string? BadgeKey { get; set; }

    public string? ButtonText { get; set; }

    public string? Features { get; set; }

    public string? ColorScheme { get; set; }

    public string? Framework { get; set; }

    public bool Responsive { get; set; }

    public bool SeoOptimized { get; set; }

    public bool EcommerceReady { get; set; }

    public bool Multilingual { get; set; }

    public int Popularity { get; set; }

    public int DownloadCount { get; set; }

    public int ViewsCount { get; set; }

    public string? PreviewLink { get; set; }

    public string Status { get; set; } = null!;

    public int? UpdatedBy { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
