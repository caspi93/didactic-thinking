using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Tables
{
    public partial class Entities : DbContext
    {
        public Entities()
        {
        }

        public Entities(DbContextOptions<Entities> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<GameQuestion> GameQuestions { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LanguageAnswer> LanguagesAnswer { get; set; }
        public virtual DbSet<LanguageQuestion> LanguagesQuestion { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Subcategorie> Subcategories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("answers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Iscorrect).HasColumnName("iscorrect");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("answers_fk");
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.ToTable("categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GameQuestion>(entity =>
            {
                entity.HasKey(e => new { e.GameId, e.QuestionId })
                    .HasName("game_questions_pk");

                entity.ToTable("game_questions");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameQuestions)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("game_questions_fk_1");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.GameQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("game_questions_fk");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("games");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoriaId).HasColumnName("categoria_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.SubcategorieId).HasColumnName("subcategorie_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.CategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("games_fk_1");

                entity.HasOne(d => d.Subcategorie)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.SubcategorieId)
                    .HasConstraintName("games_fk_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("games_fk");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("languages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LanguageAnswer>(entity =>
            {
                entity.HasKey(e => new { e.AnswerId, e.LanguageId })
                    .HasName("languages_answer_pk");

                entity.ToTable("languages_answer");

                entity.Property(e => e.AnswerId).HasColumnName("answer_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.LanguagesAnswer)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("languages_answer_fk_1");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LanguagesAnswer)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("languages_answer_fk");
            });

            modelBuilder.Entity<LanguageQuestion>(entity =>
            {
                entity.HasKey(e => new { e.QuestionId, e.LanguageId })
                    .HasName("languages_question_pk");

                entity.ToTable("languages_question");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LanguagesQuestion)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("languages_question_fk");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.LanguagesQuestion)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("languages_question_fk_1");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("questions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SubcategorieId).HasColumnName("subcategorie_id");

                entity.HasOne(d => d.Subcategorie)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.SubcategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("questions_fk");
            });

            modelBuilder.Entity<Subcategorie>(entity =>
            {
                entity.ToTable("subcategories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategorieId).HasColumnName("categorie_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Categorie)
                    .WithMany(p => p.Subcategories)
                    .HasForeignKey(d => d.CategorieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("subcategories_fk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.LanguajeId).HasColumnName("languaje_id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(16);

                entity.Property(e => e.Picture).HasColumnName("picture");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Languaje)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.LanguajeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
