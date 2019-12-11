using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EChargerInternational.EChargerInternational
{
    public partial class EChargerInternationalContext : DbContext
    {
        public EChargerInternationalContext()
        {
        }

        public EChargerInternationalContext(DbContextOptions<EChargerInternationalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aikstele> Aikstele { get; set; }
        public virtual DbSet<Aspnetroleclaims> Aspnetroleclaims { get; set; }
        public virtual DbSet<Aspnetroles> Aspnetroles { get; set; }
        public virtual DbSet<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        public virtual DbSet<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        public virtual DbSet<Aspnetuserroles> Aspnetuserroles { get; set; }
        public virtual DbSet<Aspnetusers> Aspnetusers { get; set; }
        public virtual DbSet<Aspnetusertokens> Aspnetusertokens { get; set; }
        public virtual DbSet<Atsiliepimas> Atsiliepimas { get; set; }
        public virtual DbSet<Kalba> Kalba { get; set; }
        public virtual DbSet<Kalbos> Kalbos { get; set; }
        public virtual DbSet<Klientas> Klientas { get; set; }
        public virtual DbSet<Klientokalbos> Klientokalbos { get; set; }
        public virtual DbSet<Remejai> Remejai { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<RezervacijosBusena> RezervacijosBusena { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Skundas> Skundas { get; set; }
        public virtual DbSet<SkundoBusena> SkundoBusena { get; set; }
        public virtual DbSet<Stotele> Stotele { get; set; }
        public virtual DbSet<Vertinimas> Vertinimas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;database=EChargerInternational;uid=root;password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aikstele>(entity =>
            {
                entity.HasKey(e => e.IdAikstele);

                entity.ToTable("aikstele", "echargerinternational");

                entity.HasIndex(e => e.FkKlientasidKlientas)
                    .HasName("Administruoja");

                entity.Property(e => e.IdAikstele)
                    .HasColumnName("id_Aikstele")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aprasymas)
                    .IsRequired()
                    .HasColumnName("aprasymas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DarboPabaiga).HasColumnName("darbo_pabaiga");

                entity.Property(e => e.DarboPradzia).HasColumnName("darbo_pradzia");

                entity.Property(e => e.ElektrosKaina)
                    .HasColumnName("elektros_kaina")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FkKlientasidKlientas)
                    .HasColumnName("fk_Klientasid_Klientas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Gatve)
                    .IsRequired()
                    .HasColumnName("gatve")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KoordinateX)
                    .HasColumnName("koordinateX")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.KoordinateY)
                    .HasColumnName("koordinateY")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Miestas)
                    .IsRequired()
                    .HasColumnName("miestas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NamoNr)
                    .HasColumnName("namoNr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PapildomasMokestis)
                    .HasColumnName("papildomas_mokestis")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.PapildomoMokescioAprasymas)
                    .IsRequired()
                    .HasColumnName("papildomo_mokescio_aprasymas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PastoKodas)
                    .IsRequired()
                    .HasColumnName("pasto_kodas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pavadinimas)
                    .IsRequired()
                    .HasColumnName("pavadinimas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Saugoma)
                    .HasColumnName("saugoma")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.TelefonoNumeris)
                    .IsRequired()
                    .HasColumnName("telefono_numeris")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkKlientasidKlientasNavigation)
                    .WithMany(p => p.Aikstele)
                    .HasForeignKey(d => d.FkKlientasidKlientas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Administruoja");
            });

            modelBuilder.Entity<Aspnetroleclaims>(entity =>
            {
                entity.ToTable("aspnetroleclaims", "echargerinternational");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaimType).IsUnicode(false);

                entity.Property(e => e.ClaimValue).IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<Aspnetroles>(entity =>
            {
                entity.ToTable("aspnetroles", "echargerinternational");

                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ConcurrencyStamp).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NormalizedName)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Aspnetuserclaims>(entity =>
            {
                entity.ToTable("aspnetuserclaims", "echargerinternational");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaimType).IsUnicode(false);

                entity.Property(e => e.ClaimValue).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserlogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.ToTable("aspnetuserlogins", "echargerinternational");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderKey)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderDisplayName).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserroles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("aspnetuserroles", "echargerinternational");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.RoleId).IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetusers>(entity =>
            {
                entity.ToTable("aspnetusers", "echargerinternational");

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.ConcurrencyStamp).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.EmailConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.LockoutEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.NormalizedEmail)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NormalizedUserName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.PhoneNumberConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.SecurityStamp).IsUnicode(false);

                entity.Property(e => e.TwoFactorEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Aspnetusertokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.ToTable("aspnetusertokens", "echargerinternational");

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.LoginProvider)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Atsiliepimas>(entity =>
            {
                entity.HasKey(e => e.IdAtsiliepimas);

                entity.ToTable("atsiliepimas", "echargerinternational");

                entity.HasIndex(e => e.FkAiksteleidAikstele)
                    .HasName("Apibūdina");

                entity.HasIndex(e => e.FkKlientasidKlientas)
                    .HasName("Palieka");

                entity.Property(e => e.IdAtsiliepimas)
                    .HasColumnName("id_Atsiliepimas")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aprasymas)
                    .IsRequired()
                    .HasColumnName("aprasymas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.FkAiksteleidAikstele)
                    .HasColumnName("fk_Aiksteleid_Aikstele")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkKlientasidKlientas)
                    .HasColumnName("fk_Klientasid_Klientas")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkAiksteleidAiksteleNavigation)
                    .WithMany(p => p.Atsiliepimas)
                    .HasForeignKey(d => d.FkAiksteleidAikstele)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Apibūdina");

                entity.HasOne(d => d.FkKlientasidKlientasNavigation)
                    .WithMany(p => p.Atsiliepimas)
                    .HasForeignKey(d => d.FkKlientasidKlientas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Palieka");
            });

            modelBuilder.Entity<Kalba>(entity =>
            {
                entity.HasKey(e => e.IdKalba);

                entity.ToTable("kalba", "echargerinternational");

                entity.HasIndex(e => e.Kalba1)
                    .HasName("kalba");

                entity.Property(e => e.IdKalba)
                    .HasColumnName("id_Kalba")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Kalba1)
                    .HasColumnName("kalba")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Kalba1Navigation)
                    .WithMany(p => p.Kalba)
                    .HasForeignKey(d => d.Kalba1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Kalba_ibfk_1");
            });

            modelBuilder.Entity<Kalbos>(entity =>
            {
                entity.HasKey(e => e.IdKalbos);

                entity.ToTable("kalbos", "echargerinternational");

                entity.Property(e => e.IdKalbos)
                    .HasColumnName("id_Kalbos")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(8)");
            });

            modelBuilder.Entity<Klientas>(entity =>
            {
                entity.HasKey(e => e.IdKlientas);

                entity.ToTable("klientas", "echargerinternational");

                entity.HasIndex(e => e.FkRoleidRole)
                    .HasName("Priklauso");

                entity.Property(e => e.IdKlientas)
                    .HasColumnName("id_Klientas")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aprasymas)
                    .IsRequired()
                    .HasColumnName("aprasymas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AsmensKodas)
                    .IsRequired()
                    .HasColumnName("asmens_kodas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Busena)
                    .HasColumnName("busena")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Epastas)
                    .IsRequired()
                    .HasColumnName("epastas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FkRoleidRole)
                    .HasColumnName("fk_Roleid_Role")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GimimoData)
                    .HasColumnName("gimimo_data")
                    .HasColumnType("date");

                entity.Property(e => e.Pavarde)
                    .IsRequired()
                    .HasColumnName("pavarde")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Slaptazodis)
                    .IsRequired()
                    .HasColumnName("slaptazodis")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefonas)
                    .IsRequired()
                    .HasColumnName("telefonas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Vardas)
                    .IsRequired()
                    .HasColumnName("vardas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkRoleidRoleNavigation)
                    .WithMany(p => p.Klientas)
                    .HasForeignKey(d => d.FkRoleidRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Priklauso");
            });

            modelBuilder.Entity<Klientokalbos>(entity =>
            {
                entity.HasKey(e => new { e.FkKalbaidKalba, e.FkKlientasidKlientas });

                entity.ToTable("klientokalbos", "echargerinternational");

                entity.Property(e => e.FkKalbaidKalba)
                    .HasColumnName("fk_Kalbaid_Kalba")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkKlientasidKlientas)
                    .HasColumnName("fk_Klientasid_Klientas")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkKalbaidKalbaNavigation)
                    .WithMany(p => p.Klientokalbos)
                    .HasForeignKey(d => d.FkKalbaidKalba)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Kalba");
            });

            modelBuilder.Entity<Remejai>(entity =>
            {
                entity.HasKey(e => e.IdRemėjai);

                entity.ToTable("remejai", "echargerinternational");

                entity.Property(e => e.IdRemėjai)
                    .HasColumnName("id_Remėjai")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aprasymas)
                    .IsRequired()
                    .HasColumnName("aprasymas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Pavadinimas)
                    .IsRequired()
                    .HasColumnName("pavadinimas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Salis)
                    .IsRequired()
                    .HasColumnName("salis")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SkirtosLesos)
                    .HasColumnName("skirtos_lesos")
                    .HasColumnType("decimal(10,0)");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.HasKey(e => e.IdRezervacija);

                entity.ToTable("rezervacija", "echargerinternational");

                entity.HasIndex(e => e.Busena)
                    .HasName("busena");

                entity.HasIndex(e => e.FkKlientasidGavejas)
                    .HasName("Pateikia");

                entity.HasIndex(e => e.FkKlientasidSiuntejas)
                    .HasName("Pateikta");

                entity.Property(e => e.IdRezervacija)
                    .HasColumnName("id_Rezervacija")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Busena)
                    .HasColumnName("busena")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkKlientasidGavejas)
                    .HasColumnName("fk_Klientasid_Gavejas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkKlientasidSiuntejas)
                    .HasColumnName("fk_Klientasid_Siuntejas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numeris)
                    .HasColumnName("numeris")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pabaiga).HasColumnName("pabaiga");

                entity.Property(e => e.Pradzia).HasColumnName("pradzia");

                entity.Property(e => e.Pranesimas)
                    .IsRequired()
                    .HasColumnName("pranesimas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SutartiesData).HasColumnName("sutarties_data");

                entity.HasOne(d => d.BusenaNavigation)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.Busena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rezervacija_ibfk_1");

                entity.HasOne(d => d.FkKlientasidGavejasNavigation)
                    .WithMany(p => p.RezervacijaFkKlientasidGavejasNavigation)
                    .HasForeignKey(d => d.FkKlientasidGavejas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pateikia");

                entity.HasOne(d => d.FkKlientasidSiuntejasNavigation)
                    .WithMany(p => p.RezervacijaFkKlientasidSiuntejasNavigation)
                    .HasForeignKey(d => d.FkKlientasidSiuntejas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pateikta");
            });

            modelBuilder.Entity<RezervacijosBusena>(entity =>
            {
                entity.HasKey(e => e.IdRezervacijosBusena);

                entity.ToTable("rezervacijos_busena", "echargerinternational");

                entity.Property(e => e.IdRezervacijosBusena)
                    .HasColumnName("id_Rezervacijos_busena")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(9)");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.ToTable("role", "echargerinternational");

                entity.Property(e => e.IdRole)
                    .HasColumnName("id_Role")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Naudojama)
                    .HasColumnName("naudojama")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Pavadinimas)
                    .IsRequired()
                    .HasColumnName("pavadinimas")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skundas>(entity =>
            {
                entity.HasKey(e => e.IdSkundas);

                entity.ToTable("skundas", "echargerinternational");

                entity.HasIndex(e => e.Busena)
                    .HasName("busena");

                entity.HasIndex(e => e.FkKlientasidKlientas)
                    .HasName("Apie");

                entity.HasIndex(e => e.FkKlientasidKlientas1)
                    .HasName("Sukuria");

                entity.Property(e => e.IdSkundas)
                    .HasColumnName("id_Skundas")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aprasymas)
                    .IsRequired()
                    .HasColumnName("aprasymas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Busena)
                    .HasColumnName("busena")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.FkKlientasidKlientas)
                    .HasColumnName("fk_Klientasid_Klientas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkKlientasidKlientas1)
                    .HasColumnName("fk_Klientasid_Klientas1")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.BusenaNavigation)
                    .WithMany(p => p.Skundas)
                    .HasForeignKey(d => d.Busena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Skundas_ibfk_1");

                entity.HasOne(d => d.FkKlientasidKlientasNavigation)
                    .WithMany(p => p.SkundasFkKlientasidKlientasNavigation)
                    .HasForeignKey(d => d.FkKlientasidKlientas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Apie");

                entity.HasOne(d => d.FkKlientasidKlientas1Navigation)
                    .WithMany(p => p.SkundasFkKlientasidKlientas1Navigation)
                    .HasForeignKey(d => d.FkKlientasidKlientas1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Sukuria");
            });

            modelBuilder.Entity<SkundoBusena>(entity =>
            {
                entity.HasKey(e => e.IdSkundoBusena);

                entity.ToTable("skundo_busena", "echargerinternational");

                entity.Property(e => e.IdSkundoBusena)
                    .HasColumnName("id_Skundo_busena")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(7)");
            });

            modelBuilder.Entity<Stotele>(entity =>
            {
                entity.HasKey(e => e.IdStotele);

                entity.ToTable("stotele", "echargerinternational");

                entity.HasIndex(e => e.FkAiksteleidAikstele)
                    .HasName("Turi");

                entity.Property(e => e.IdStotele)
                    .HasColumnName("id_Stotele")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aprasymas)
                    .IsRequired()
                    .HasColumnName("aprasymas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FkAiksteleidAikstele)
                    .HasColumnName("fk_Aiksteleid_Aikstele")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Galia)
                    .HasColumnName("galia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numeris)
                    .HasColumnName("numeris")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValandinisMokestis)
                    .HasColumnName("valandinis_mokestis")
                    .HasColumnType("decimal(10,0)");

                entity.HasOne(d => d.FkAiksteleidAiksteleNavigation)
                    .WithMany(p => p.Stotele)
                    .HasForeignKey(d => d.FkAiksteleidAikstele)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Turi");
            });

            modelBuilder.Entity<Vertinimas>(entity =>
            {
                entity.HasKey(e => e.IdVertinimas);

                entity.ToTable("vertinimas", "echargerinternational");

                entity.HasIndex(e => e.FkAiksteleidAikstele)
                    .HasName("Skirtas");

                entity.HasIndex(e => e.FkKlientasidKlientas)
                    .HasName("fk_Klientasid_Klientas")
                    .IsUnique();

                entity.Property(e => e.IdVertinimas)
                    .HasColumnName("id_Vertinimas")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.FkAiksteleidAikstele)
                    .HasColumnName("fk_Aiksteleid_Aikstele")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkKlientasidKlientas)
                    .HasColumnName("fk_Klientasid_Klientas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reitingas).HasColumnName("reitingas");

                entity.HasOne(d => d.FkAiksteleidAiksteleNavigation)
                    .WithMany(p => p.Vertinimas)
                    .HasForeignKey(d => d.FkAiksteleidAikstele)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Skirtas");

                entity.HasOne(d => d.FkKlientasidKlientasNavigation)
                    .WithOne(p => p.Vertinimas)
                    .HasForeignKey<Vertinimas>(d => d.FkKlientasidKlientas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Kuria");
            });
        }
    }
}
