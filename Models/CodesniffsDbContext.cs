using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeSniffs.API.Models;

public partial class CodesniffsDbContext : DbContext
{
    public CodesniffsDbContext()
    {
    }

    public CodesniffsDbContext(DbContextOptions<CodesniffsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminLog> AdminLogs { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<ContactMessage> ContactMessages { get; set; }

    public virtual DbSet<EmailLog> EmailLogs { get; set; }

    public virtual DbSet<EmailVerification> EmailVerifications { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<OtpLog> OtpLogs { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<SignupLog> SignupLogs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__admin_lo__3213E83F6DC55812");

            entity.ToTable("admin_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(100)
                .HasColumnName("action");
            entity.Property(e => e.AdminId).HasColumnName("admin_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(45)
                .HasColumnName("ip_address");
            entity.Property(e => e.UserAgent).HasColumnName("user_agent");
        });

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__admin_us__3213E83F0CA9483C");

            entity.ToTable("admin_users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.FailedLoginAttempts).HasColumnName("failed_login_attempts");
            entity.Property(e => e.FullName)
                .HasMaxLength(150)
                .HasColumnName("full_name");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.LastLogin)
                .HasColumnType("datetime")
                .HasColumnName("last_login");
            entity.Property(e => e.LastLoginIp)
                .HasMaxLength(45)
                .HasColumnName("last_login_ip");
            entity.Property(e => e.LockUntil)
                .HasColumnType("datetime")
                .HasColumnName("lock_until");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasColumnName("password_hash");
            entity.Property(e => e.Permissions).HasColumnName("permissions");
            entity.Property(e => e.Role)
                .HasMaxLength(20)
                .HasDefaultValue("admin")
                .HasColumnName("role");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("updated_at");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__categori__3213E83F56F7A1C5");

            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BannerText)
                .HasMaxLength(100)
                .HasColumnName("banner_text");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .HasDefaultValue("#dc2626")
                .HasColumnName("color");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IconClass)
                .HasMaxLength(50)
                .HasDefaultValue("fas fa-tag")
                .HasColumnName("icon_class");
            entity.Property(e => e.Image)
                .HasMaxLength(500)
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.NameKey)
                .HasMaxLength(100)
                .HasColumnName("name_key");
            entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("active")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<ContactMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__contact___3213E83F24BAA151");

            entity.ToTable("contact_messages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attachments).HasColumnName("attachments");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("first_name");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(45)
                .HasColumnName("ip_address");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("last_name");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Priority)
                .HasMaxLength(10)
                .HasDefaultValue("medium")
                .HasColumnName("priority");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("new")
                .HasColumnName("status");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("subject");
            entity.Property(e => e.UserAgent).HasColumnName("user_agent");
        });

        modelBuilder.Entity<EmailLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__email_lo__3213E83FDB7A8D08");

            entity.ToTable("email_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.DebugInfo).HasColumnName("debug_info");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .HasColumnName("email_address");
            entity.Property(e => e.OtpCode)
                .HasMaxLength(10)
                .HasColumnName("otp_code");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
        });

        modelBuilder.Entity<EmailVerification>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__email_ve__AB6E61653A3B69C3");

            entity.ToTable("email_verification");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.ExpiresAt).HasColumnName("expires_at");
            entity.Property(e => e.Otp)
                .HasMaxLength(10)
                .HasColumnName("otp");
            entity.Property(e => e.Verified).HasColumnName("verified");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__error_lo__3213E83F8733FECF");

            entity.ToTable("error_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.ErrorType)
                .HasMaxLength(50)
                .HasDefaultValue("general")
                .HasColumnName("error_type");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("file_name");
            entity.Property(e => e.LineNumber).HasColumnName("line_number");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(255)
                .HasColumnName("user_email");
        });

        modelBuilder.Entity<OtpLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__otp_logs__3213E83F684F093C");

            entity.ToTable("otp_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Otp)
                .HasMaxLength(10)
                .HasColumnName("otp");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("sent")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__products__3213E83F140BACF4");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BadgeKey)
                .HasMaxLength(100)
                .HasColumnName("badge_key");
            entity.Property(e => e.BadgeText)
                .HasMaxLength(50)
                .HasColumnName("badge_text");
            entity.Property(e => e.ButtonText)
                .HasMaxLength(50)
                .HasColumnName("button_text");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.ColorScheme)
                .HasMaxLength(50)
                .HasColumnName("color_scheme");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DescriptionKey)
                .HasMaxLength(100)
                .HasColumnName("description_key");
            entity.Property(e => e.Document)
                .HasMaxLength(255)
                .HasColumnName("document");
            entity.Property(e => e.DocumentUrl)
                .HasMaxLength(500)
                .HasColumnName("document_url");
            entity.Property(e => e.DownloadCount).HasColumnName("download_count");
            entity.Property(e => e.EcommerceReady).HasColumnName("ecommerce_ready");
            entity.Property(e => e.Features).HasColumnName("features");
            entity.Property(e => e.FileSize).HasColumnName("file_size");
            entity.Property(e => e.FileType)
                .HasMaxLength(100)
                .HasColumnName("file_type");
            entity.Property(e => e.Framework)
                .HasMaxLength(50)
                .HasColumnName("framework");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .HasColumnName("image_url");
            entity.Property(e => e.IsPopular).HasColumnName("is_popular");
            entity.Property(e => e.MetaDescription).HasColumnName("meta_description");
            entity.Property(e => e.MetaKeywords).HasColumnName("meta_keywords");
            entity.Property(e => e.Multilingual).HasColumnName("multilingual");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NameKey)
                .HasMaxLength(100)
                .HasColumnName("name_key");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Period)
                .HasMaxLength(50)
                .HasColumnName("period");
            entity.Property(e => e.Popularity).HasColumnName("popularity");
            entity.Property(e => e.PreviewLink)
                .HasMaxLength(500)
                .HasColumnName("preview_link");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.Responsive)
                .HasDefaultValue(true)
                .HasColumnName("responsive");
            entity.Property(e => e.SeoOptimized)
                .HasDefaultValue(true)
                .HasColumnName("seo_optimized");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("active")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.ViewsCount).HasColumnName("views_count");
        });

        modelBuilder.Entity<SignupLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__signup_l__3213E83F6BD18F81");

            entity.ToTable("signup_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(20)
                .HasColumnName("contact_number");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("full_name");
            entity.Property(e => e.OtpSent).HasColumnName("otp_sent");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasColumnName("password_hash");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("pending")
                .HasColumnName("status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83FD5ADC187");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contact)
                .HasMaxLength(20)
                .HasColumnName("contact");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(20)
                .HasColumnName("contact_number");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.EmergencyContact)
                .HasMaxLength(255)
                .HasColumnName("emergency_contact");
            entity.Property(e => e.EmergencyContactIv)
                .HasMaxLength(64)
                .HasColumnName("emergency_contact_iv");
            entity.Property(e => e.FailedLoginAttempts).HasColumnName("failed_login_attempts");
            entity.Property(e => e.FullName)
                .HasMaxLength(150)
                .HasColumnName("full_name");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(45)
                .HasColumnName("ip_address");
            entity.Property(e => e.IsVerified).HasColumnName("is_verified");
            entity.Property(e => e.LastLoginAt).HasColumnName("last_login_at");
            entity.Property(e => e.LockUntil).HasColumnName("lock_until");
            entity.Property(e => e.PasswordChangedAt).HasColumnName("password_changed_at");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasColumnName("password_hash");
            entity.Property(e => e.PasswordResetExpires).HasColumnName("password_reset_expires");
            entity.Property(e => e.PasswordResetToken)
                .HasMaxLength(100)
                .HasColumnName("password_reset_token");
            entity.Property(e => e.PhoneEncrypted)
                .HasMaxLength(255)
                .HasColumnName("phone_encrypted");
            entity.Property(e => e.PhoneIv)
                .HasMaxLength(64)
                .HasColumnName("phone_iv");
            entity.Property(e => e.ResetToken)
                .HasMaxLength(64)
                .HasColumnName("reset_token");
            entity.Property(e => e.ResetTokenExpires)
                .HasColumnType("datetime")
                .HasColumnName("reset_token_expires");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("active")
                .HasColumnName("status");
            entity.Property(e => e.TokenExpires).HasColumnName("token_expires");
            entity.Property(e => e.TwoFactorSecret)
                .HasMaxLength(255)
                .HasColumnName("two_factor_secret");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserAgent).HasColumnName("user_agent");
            entity.Property(e => e.VerificationToken)
                .HasMaxLength(100)
                .HasColumnName("verification_token");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
