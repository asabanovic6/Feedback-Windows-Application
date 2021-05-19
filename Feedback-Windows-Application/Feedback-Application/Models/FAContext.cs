using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Feedback_Application.Models
{
    public partial class FAContext : DbContext
    {
        public FAContext()
        {
        }

        public FAContext(DbContextOptions<FAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Fadevice> Fadevices { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<UserResponse> UserResponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "FALocalDB.mdf;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.AnswerId)
                    .ValueGeneratedNever()
                    .HasColumnName("AnswerID");

                entity.Property(e => e.AnswerText).IsRequired();

                entity.Property(e => e.IsApicture).HasColumnName("isAPicture");
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.ToTable("Campaign");

                entity.Property(e => e.CampaignId)
                    .ValueGeneratedNever()
                    .HasColumnName("CampaignID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fadevice>(entity =>
            {
                entity.HasKey(e => e.DeviceId)
                    .HasName("PK__FADevice__49E1233107BF9BA9");

                entity.ToTable("FADevice");

                entity.Property(e => e.DeviceId)
                    .ValueGeneratedNever()
                    .HasColumnName("DeviceID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.Fadevices)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FADevice_Campaign");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.QuestionId)
                    .ValueGeneratedNever()
                    .HasColumnName("QuestionID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.QuestionText).IsRequired();

                entity.Property(e => e.QuestionType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Campaign");
            });

            modelBuilder.Entity<QuestionAnswer>(entity =>
            {
                entity.ToTable("QuestionAnswer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionAnswer_Answer");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionAnswer_Question");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("Session");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Session_Campaign");
            });

            modelBuilder.Entity<UserResponse>(entity =>
            {
                entity.ToTable("UserResponse");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.UserResponses)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserResponse_Answer");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.UserResponses)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserResponse_Question");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.UserResponses)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserResponse_Session");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
