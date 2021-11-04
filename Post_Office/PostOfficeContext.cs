using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Post_Office
{
    public partial class PostOfficeContext : DbContext
    {
        public PostOfficeContext()
        {
        }

        public PostOfficeContext(DbContextOptions<PostOfficeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Parcel> Parcels { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PostOffice> PostOffices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-C18IDHU;Database=Post Office;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.ParcelId).HasColumnName("parcel_id");

                entity.Property(e => e.PhoneNumber).HasColumnName("Phone_number");
            });

            modelBuilder.Entity<Parcel>(entity =>
            {
                entity.ToTable("parcel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdressId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("adress_id")
                    .IsFixedLength(true);

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("Client_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("First_name")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("Last_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PostOffice>(entity =>
            {
                entity.HasKey(e => e.AdressId);

                entity.ToTable("Post_office");

                entity.Property(e => e.AdressId)
                    .HasMaxLength(5)
                    .HasColumnName("adress_id")
                    .IsFixedLength(true);

                entity.Property(e => e.PostOffice1).HasColumnName("post_office");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
