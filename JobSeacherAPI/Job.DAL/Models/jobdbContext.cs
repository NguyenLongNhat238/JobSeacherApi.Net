using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Job.DAL.Models
{
    public partial class jobdbContext : DbContext
    {
        public jobdbContext()
        {
        }

        public jobdbContext(DbContextOptions<jobdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthGroup> AuthGroups { get; set; }
        public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; }
        public virtual DbSet<AuthPermission> AuthPermissions { get; set; }
        public virtual DbSet<AuthtokenToken> AuthtokenTokens { get; set; }
        public virtual DbSet<DjangoAdminLog> DjangoAdminLogs { get; set; }
        public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; }
        public virtual DbSet<DjangoMigration> DjangoMigrations { get; set; }
        public virtual DbSet<DjangoSession> DjangoSessions { get; set; }
        public virtual DbSet<JobsApply> JobsApplies { get; set; }
        public virtual DbSet<JobsCategory> JobsCategories { get; set; }
        public virtual DbSet<JobsComment> JobsComments { get; set; }
        public virtual DbSet<JobsMajor> JobsMajors { get; set; }
        public virtual DbSet<JobsPost> JobsPosts { get; set; }
        public virtual DbSet<JobsRating> JobsRatings { get; set; }
        public virtual DbSet<JobsToken> JobsTokens { get; set; }
        public virtual DbSet<JobsUser> JobsUsers { get; set; }
        public virtual DbSet<JobsUserGroup> JobsUserGroups { get; set; }
        public virtual DbSet<JobsUserUserPermission> JobsUserUserPermissions { get; set; }
        public virtual DbSet<JobsWaiting> JobsWaitings { get; set; }
        public virtual DbSet<Oauth2ProviderAccesstoken> Oauth2ProviderAccesstokens { get; set; }
        public virtual DbSet<Oauth2ProviderApplication> Oauth2ProviderApplications { get; set; }
        public virtual DbSet<Oauth2ProviderGrant> Oauth2ProviderGrants { get; set; }
        public virtual DbSet<Oauth2ProviderIdtoken> Oauth2ProviderIdtokens { get; set; }
        public virtual DbSet<Oauth2ProviderRefreshtoken> Oauth2ProviderRefreshtokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=PIN-PC;Initial Catalog=jobdb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AuthGroup>(entity =>
            {
                entity.ToTable("auth_group", "jobdb");

                entity.HasIndex(e => e.Name, "auth_group$name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AuthGroupPermission>(entity =>
            {
                entity.ToTable("auth_group_permissions", "jobdb");

                entity.HasIndex(e => e.PermissionId, "auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");

                entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions$auth_group_permissions_group_id_permission_id_0cd325b0_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissions$auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissions$auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
            });

            modelBuilder.Entity<AuthPermission>(entity =>
            {
                entity.ToTable("auth_permission", "jobdb");

                entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission$auth_permission_content_type_id_codename_01ab375a_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("codename");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.AuthPermissions)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_permission$auth_permission_content_type_id_2f476e4b_fk_django_co");
            });

            modelBuilder.Entity<AuthtokenToken>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_authtoken_token_key");

                entity.ToTable("authtoken_token", "jobdb");

                entity.HasIndex(e => e.UserId, "authtoken_token$user_id")
                    .IsUnique();

                entity.Property(e => e.Key)
                    .HasMaxLength(40)
                    .HasColumnName("key");

                entity.Property(e => e.Created)
                    .HasPrecision(6)
                    .HasColumnName("created");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AuthtokenToken)
                    .HasForeignKey<AuthtokenToken>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("authtoken_token$authtoken_token_user_id_35299eff_fk_jobs_user_id");
            });

            modelBuilder.Entity<DjangoAdminLog>(entity =>
            {
                entity.ToTable("django_admin_log", "jobdb");

                entity.HasIndex(e => e.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb_fk_django_co");

                entity.HasIndex(e => e.UserId, "django_admin_log_user_id_c564eba6_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionFlag).HasColumnName("action_flag");

                entity.Property(e => e.ActionTime)
                    .HasPrecision(6)
                    .HasColumnName("action_time");

                entity.Property(e => e.ChangeMessage)
                    .IsRequired()
                    .HasColumnName("change_message");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectRepr)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("object_repr");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.DjangoAdminLogs)
                    .HasForeignKey(d => d.ContentTypeId)
                    .HasConstraintName("django_admin_log$django_admin_log_content_type_id_c4bce8eb_fk_django_co");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DjangoAdminLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_admin_log$django_admin_log_user_id_c564eba6_fk_jobs_user_id");
            });

            modelBuilder.Entity<DjangoContentType>(entity =>
            {
                entity.ToTable("django_content_type", "jobdb");

                entity.HasIndex(e => new { e.AppLabel, e.Model }, "django_content_type$django_content_type_app_label_model_76bd3d3b_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("app_label");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("model");
            });

            modelBuilder.Entity<DjangoMigration>(entity =>
            {
                entity.ToTable("django_migrations", "jobdb");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.App)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("app");

                entity.Property(e => e.Applied)
                    .HasPrecision(6)
                    .HasColumnName("applied");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DjangoSession>(entity =>
            {
                entity.HasKey(e => e.SessionKey)
                    .HasName("PK_django_session_session_key");

                entity.ToTable("django_session", "jobdb");

                entity.HasIndex(e => e.ExpireDate, "django_session_expire_date_a5c62663");

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(40)
                    .HasColumnName("session_key");

                entity.Property(e => e.ExpireDate)
                    .HasPrecision(6)
                    .HasColumnName("expire_date");

                entity.Property(e => e.SessionData)
                    .IsRequired()
                    .HasColumnName("session_data");
            });

            modelBuilder.Entity<JobsApply>(entity =>
            {
                entity.ToTable("jobs_apply", "jobdb");

                entity.HasIndex(e => e.PostId, "jobs_apply_post_id_0e6de5aa_fk_jobs_post_id");

                entity.HasIndex(e => e.UserId, "jobs_apply_user_id_727fd922_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedDate)
                    .HasPrecision(6)
                    .HasColumnName("created_date");

                entity.Property(e => e.Cv)
                    .HasMaxLength(100)
                    .HasColumnName("CV");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.UpdatedDate)
                    .HasPrecision(6)
                    .HasColumnName("updated_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.JobsApplies)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_apply$jobs_apply_post_id_0e6de5aa_fk_jobs_post_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobsApplies)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_apply$jobs_apply_user_id_727fd922_fk_jobs_user_id");
            });

            modelBuilder.Entity<JobsCategory>(entity =>
            {
                entity.ToTable("jobs_category", "jobdb");

                entity.HasIndex(e => e.Name, "jobs_category$name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedDate)
                    .HasPrecision(6)
                    .HasColumnName("created_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedDate)
                    .HasPrecision(6)
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<JobsComment>(entity =>
            {
                entity.ToTable("jobs_comment", "jobdb");

                entity.HasIndex(e => e.CreatorId, "jobs_comment_creator_id_ae74a745_fk_jobs_user_id");

                entity.HasIndex(e => e.HirerId, "jobs_comment_hirer_id_fb1213e0_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.CreatedDate)
                    .HasPrecision(6)
                    .HasColumnName("created_date");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.HirerId).HasColumnName("hirer_id");

                entity.Property(e => e.UpdatedDate)
                    .HasPrecision(6)
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.JobsCommentCreators)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_comment$jobs_comment_creator_id_ae74a745_fk_jobs_user_id");

                entity.HasOne(d => d.Hirer)
                    .WithMany(p => p.JobsCommentHirers)
                    .HasForeignKey(d => d.HirerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_comment$jobs_comment_hirer_id_fb1213e0_fk_jobs_user_id");
            });

            modelBuilder.Entity<JobsMajor>(entity =>
            {
                entity.ToTable("jobs_major", "jobdb");

                entity.HasIndex(e => e.Name, "jobs_major$name")
                    .IsUnique();

                entity.HasIndex(e => e.CategoryId, "jobs_major_category_id_8204c8fd_fk_jobs_category_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreatedDate)
                    .HasPrecision(6)
                    .HasColumnName("created_date");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedDate)
                    .HasPrecision(6)
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.JobsMajors)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("jobs_major$jobs_major_category_id_8204c8fd_fk_jobs_category_id");
            });

            modelBuilder.Entity<JobsPost>(entity =>
            {
                entity.ToTable("jobs_post", "jobdb");

                entity.HasIndex(e => e.MajorId, "jobs_post_major_id_20bd7e32_fk_jobs_major_id");

                entity.HasIndex(e => e.UserId, "jobs_post_user_id_d4bf4781_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.CreatedDate)
                    .HasPrecision(6)
                    .HasColumnName("created_date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Due)
                    .HasPrecision(6)
                    .HasColumnName("due");

                entity.Property(e => e.FromSalary).HasColumnName("from_salary");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("gender");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.MajorId).HasColumnName("major_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TimeWork)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("time_work");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.ToSalary).HasColumnName("to_salary");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedDate)
                    .HasPrecision(6)
                    .HasColumnName("updated_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.JobsPosts)
                    .HasForeignKey(d => d.MajorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_post$jobs_post_major_id_20bd7e32_fk_jobs_major_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobsPosts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_post$jobs_post_user_id_d4bf4781_fk_jobs_user_id");
            });

            modelBuilder.Entity<JobsRating>(entity =>
            {
                entity.ToTable("jobs_rating", "jobdb");

                entity.HasIndex(e => e.CreatorId, "jobs_rating_creator_id_776f361e_fk_jobs_user_id");

                entity.HasIndex(e => e.HirerId, "jobs_rating_hirer_id_77b212a0_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedDate)
                    .HasPrecision(6)
                    .HasColumnName("created_date");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.HirerId).HasColumnName("hirer_id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.UpdatedDate)
                    .HasPrecision(6)
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.JobsRatingCreators)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_rating$jobs_rating_creator_id_776f361e_fk_jobs_user_id");

                entity.HasOne(d => d.Hirer)
                    .WithMany(p => p.JobsRatingHirers)
                    .HasForeignKey(d => d.HirerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_rating$jobs_rating_hirer_id_77b212a0_fk_jobs_user_id");
            });

            modelBuilder.Entity<JobsToken>(entity =>
            {
                entity.ToTable("jobs_token", "jobdb");

                entity.HasIndex(e => e.UserId, "jobs_token_user_id_443fe749_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Token)
                    .HasMaxLength(256)
                    .HasColumnName("token");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobsTokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_token$jobs_token_user_id_443fe749_fk_jobs_user_id");
            });

            modelBuilder.Entity<JobsUser>(entity =>
            {
                entity.ToTable("jobs_user", "jobdb");

                entity.HasIndex(e => e.Username, "jobs_user$username")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(100)
                    .HasColumnName("avatar");

                entity.Property(e => e.DateJoined)
                    .HasPrecision(6)
                    .HasColumnName("date_joined");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("first_name");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsStaff).HasColumnName("is_staff");

                entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");

                entity.Property(e => e.LastLogin)
                    .HasPrecision(6)
                    .HasColumnName("last_login");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("password");

                entity.Property(e => e.UserRole).HasColumnName("user_role");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<JobsUserGroup>(entity =>
            {
                entity.ToTable("jobs_user_groups", "jobdb");

                entity.HasIndex(e => new { e.UserId, e.GroupId }, "jobs_user_groups$jobs_user_groups_user_id_group_id_39db2e61_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.GroupId, "jobs_user_groups_group_id_8c4ec9ac_fk_auth_group_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.JobsUserGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_user_groups$jobs_user_groups_group_id_8c4ec9ac_fk_auth_group_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobsUserGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_user_groups$jobs_user_groups_user_id_c74ea82a_fk_jobs_user_id");
            });

            modelBuilder.Entity<JobsUserUserPermission>(entity =>
            {
                entity.ToTable("jobs_user_user_permissions", "jobdb");

                entity.HasIndex(e => e.PermissionId, "jobs_user_user_permi_permission_id_e171478b_fk_auth_perm");

                entity.HasIndex(e => new { e.UserId, e.PermissionId }, "jobs_user_user_permissions$jobs_user_user_permissions_user_id_permission_id_80875a4d_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.JobsUserUserPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_user_user_permissions$jobs_user_user_permi_permission_id_e171478b_fk_auth_perm");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobsUserUserPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobs_user_user_permissions$jobs_user_user_permissions_user_id_d7a33063_fk_jobs_user_id");
            });

            modelBuilder.Entity<JobsWaiting>(entity =>
            {
                entity.ToTable("jobs_waiting", "jobdb");

                entity.HasIndex(e => e.UserId, "jobs_waiting_user_id_0073a616_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedDate)
                    .HasPrecision(6)
                    .HasColumnName("created_date");

                entity.Property(e => e.UpdatedDate)
                    .HasPrecision(6)
                    .HasColumnName("updated_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobsWaitings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("jobs_waiting$jobs_waiting_user_id_0073a616_fk_jobs_user_id");
            });

            modelBuilder.Entity<Oauth2ProviderAccesstoken>(entity =>
            {
                entity.ToTable("oauth2_provider_accesstoken", "jobdb");

                entity.HasIndex(e => e.ApplicationId, "oauth2_provider_acce_application_id_b22886e1_fk_oauth2_pr");

                entity.HasIndex(e => e.IdTokenId, "oauth2_provider_accesstoken$id_token_id")
                    .IsUnique();

                entity.HasIndex(e => e.SourceRefreshTokenId, "oauth2_provider_accesstoken$source_refresh_token_id")
                    .IsUnique();

                entity.HasIndex(e => e.Token, "oauth2_provider_accesstoken$token")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "oauth2_provider_accesstoken_user_id_6e4c9a65_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.Created)
                    .HasPrecision(6)
                    .HasColumnName("created");

                entity.Property(e => e.Expires)
                    .HasPrecision(6)
                    .HasColumnName("expires");

                entity.Property(e => e.IdTokenId).HasColumnName("id_token_id");

                entity.Property(e => e.Scope)
                    .IsRequired()
                    .HasColumnName("scope");

                entity.Property(e => e.SourceRefreshTokenId).HasColumnName("source_refresh_token_id");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("token");

                entity.Property(e => e.Updated)
                    .HasPrecision(6)
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Oauth2ProviderAccesstokens)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("oauth2_provider_accesstoken$oauth2_provider_acce_application_id_b22886e1_fk_oauth2_pr");

                entity.HasOne(d => d.IdToken)
                    .WithOne(p => p.Oauth2ProviderAccesstoken)
                    .HasForeignKey<Oauth2ProviderAccesstoken>(d => d.IdTokenId)
                    .HasConstraintName("oauth2_provider_accesstoken$oauth2_provider_acce_id_token_id_85db651b_fk_oauth2_pr");

                entity.HasOne(d => d.SourceRefreshToken)
                    .WithOne(p => p.Oauth2ProviderAccesstoken)
                    .HasForeignKey<Oauth2ProviderAccesstoken>(d => d.SourceRefreshTokenId)
                    .HasConstraintName("oauth2_provider_accesstoken$oauth2_provider_acce_source_refresh_token_e66fbc72_fk_oauth2_pr");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Oauth2ProviderAccesstokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("oauth2_provider_accesstoken$oauth2_provider_accesstoken_user_id_6e4c9a65_fk_jobs_user_id");
            });

            modelBuilder.Entity<Oauth2ProviderApplication>(entity =>
            {
                entity.ToTable("oauth2_provider_application", "jobdb");

                entity.HasIndex(e => e.ClientId, "oauth2_provider_application$client_id")
                    .IsUnique();

                entity.HasIndex(e => e.ClientSecret, "oauth2_provider_application_client_secret_53133678");

                entity.HasIndex(e => e.UserId, "oauth2_provider_application_user_id_79829054_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Algorithm)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("algorithm");

                entity.Property(e => e.AuthorizationGrantType)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("authorization_grant_type");

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientSecret)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("client_secret");

                entity.Property(e => e.ClientType)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("client_type");

                entity.Property(e => e.Created)
                    .HasPrecision(6)
                    .HasColumnName("created");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.RedirectUris)
                    .IsRequired()
                    .HasColumnName("redirect_uris");

                entity.Property(e => e.SkipAuthorization).HasColumnName("skip_authorization");

                entity.Property(e => e.Updated)
                    .HasPrecision(6)
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Oauth2ProviderApplications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("oauth2_provider_application$oauth2_provider_application_user_id_79829054_fk_jobs_user_id");
            });

            modelBuilder.Entity<Oauth2ProviderGrant>(entity =>
            {
                entity.ToTable("oauth2_provider_grant", "jobdb");

                entity.HasIndex(e => e.ApplicationId, "oauth2_provider_gran_application_id_81923564_fk_oauth2_pr");

                entity.HasIndex(e => e.Code, "oauth2_provider_grant$code")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "oauth2_provider_grant_user_id_e8f62af8_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.Claims)
                    .IsRequired()
                    .HasColumnName("claims")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.CodeChallenge)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("code_challenge");

                entity.Property(e => e.CodeChallengeMethod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("code_challenge_method");

                entity.Property(e => e.Created)
                    .HasPrecision(6)
                    .HasColumnName("created");

                entity.Property(e => e.Expires)
                    .HasPrecision(6)
                    .HasColumnName("expires");

                entity.Property(e => e.Nonce)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nonce");

                entity.Property(e => e.RedirectUri)
                    .IsRequired()
                    .HasColumnName("redirect_uri");

                entity.Property(e => e.Scope)
                    .IsRequired()
                    .HasColumnName("scope");

                entity.Property(e => e.Updated)
                    .HasPrecision(6)
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Oauth2ProviderGrants)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("oauth2_provider_grant$oauth2_provider_gran_application_id_81923564_fk_oauth2_pr");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Oauth2ProviderGrants)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("oauth2_provider_grant$oauth2_provider_grant_user_id_e8f62af8_fk_jobs_user_id");
            });

            modelBuilder.Entity<Oauth2ProviderIdtoken>(entity =>
            {
                entity.ToTable("oauth2_provider_idtoken", "jobdb");

                entity.HasIndex(e => e.ApplicationId, "oauth2_provider_idto_application_id_08c5ff4f_fk_oauth2_pr");

                entity.HasIndex(e => e.Jti, "oauth2_provider_idtoken$jti")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "oauth2_provider_idtoken_user_id_dd512b59_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.Created)
                    .HasPrecision(6)
                    .HasColumnName("created");

                entity.Property(e => e.Expires)
                    .HasPrecision(6)
                    .HasColumnName("expires");

                entity.Property(e => e.Jti)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("jti")
                    .IsFixedLength(true);

                entity.Property(e => e.Scope)
                    .IsRequired()
                    .HasColumnName("scope");

                entity.Property(e => e.Updated)
                    .HasPrecision(6)
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Oauth2ProviderIdtokens)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("oauth2_provider_idtoken$oauth2_provider_idto_application_id_08c5ff4f_fk_oauth2_pr");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Oauth2ProviderIdtokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("oauth2_provider_idtoken$oauth2_provider_idtoken_user_id_dd512b59_fk_jobs_user_id");
            });

            modelBuilder.Entity<Oauth2ProviderRefreshtoken>(entity =>
            {
                entity.ToTable("oauth2_provider_refreshtoken", "jobdb");

                entity.HasIndex(e => e.ApplicationId, "oauth2_provider_refr_application_id_2d1c311b_fk_oauth2_pr");

                entity.HasIndex(e => e.AccessTokenId, "oauth2_provider_refreshtoken$access_token_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.Token, e.Revoked }, "oauth2_provider_refreshtoken$oauth2_provider_refreshtoken_token_revoked_af8a5134_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "oauth2_provider_refreshtoken_user_id_da837fce_fk_jobs_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessTokenId).HasColumnName("access_token_id");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.Created)
                    .HasPrecision(6)
                    .HasColumnName("created");

                entity.Property(e => e.Revoked)
                    .HasPrecision(6)
                    .HasColumnName("revoked");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("token");

                entity.Property(e => e.Updated)
                    .HasPrecision(6)
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.AccessToken)
                    .WithOne(p => p.Oauth2ProviderRefreshtoken)
                    .HasForeignKey<Oauth2ProviderRefreshtoken>(d => d.AccessTokenId)
                    .HasConstraintName("oauth2_provider_refreshtoken$oauth2_provider_refr_access_token_id_775e84e8_fk_oauth2_pr");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Oauth2ProviderRefreshtokens)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("oauth2_provider_refreshtoken$oauth2_provider_refr_application_id_2d1c311b_fk_oauth2_pr");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Oauth2ProviderRefreshtokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("oauth2_provider_refreshtoken$oauth2_provider_refreshtoken_user_id_da837fce_fk_jobs_user_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
