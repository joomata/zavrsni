﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Test10.Data;

namespace Test10.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190415151819_Podloga")]
    partial class Podloga
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Test10.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("DatumRodenja");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Test10.Models.Oglas", b =>
                {
                    b.Property<int>("IdOglas")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IgracId");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(140);

                    b.Property<int>("TeniskiKlubId");

                    b.HasKey("IdOglas");

                    b.HasIndex("IgracId");

                    b.HasIndex("TeniskiKlubId");

                    b.ToTable("Oglas");
                });

            modelBuilder.Entity("Test10.Models.Podloga", b =>
                {
                    b.Property<int>("IdPodloga")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivPodloga")
                        .HasMaxLength(50);

                    b.HasKey("IdPodloga");

                    b.ToTable("Podloga");
                });

            modelBuilder.Entity("Test10.Models.Poruka", b =>
                {
                    b.Property<int>("IdPoruka")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IgracPosiljateljId");

                    b.Property<string>("IgracPrimateljId");

                    b.Property<string>("TekstPoruke")
                        .IsRequired()
                        .HasMaxLength(280);

                    b.HasKey("IdPoruka");

                    b.HasIndex("IgracPosiljateljId");

                    b.HasIndex("IgracPrimateljId");

                    b.ToTable("Poruka");
                });

            modelBuilder.Entity("Test10.Models.Rezervacija", b =>
                {
                    b.Property<int>("IdRezervacija")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumVrijeme")
                        .HasColumnType("datetime");

                    b.Property<string>("IgracId");

                    b.Property<int>("TerenId");

                    b.Property<string>("UpraviteljId");

                    b.HasKey("IdRezervacija");

                    b.HasIndex("IgracId");

                    b.HasIndex("TerenId");

                    b.HasIndex("UpraviteljId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("Test10.Models.TeniskiKlub", b =>
                {
                    b.Property<int>("IdTeniskiKlub")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa")
                        .HasMaxLength(50);

                    b.Property<int>("BrojTerena");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UpraviteljId");

                    b.HasKey("IdTeniskiKlub");

                    b.HasIndex("UpraviteljId");

                    b.ToTable("TeniskiKlub");
                });

            modelBuilder.Entity("Test10.Models.Teren", b =>
                {
                    b.Property<int>("IdTeren")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PodlogaId");

                    b.Property<string>("Prostor")
                        .HasMaxLength(50);

                    b.Property<int>("TeniskiKlubId");

                    b.HasKey("IdTeren");

                    b.HasIndex("PodlogaId");

                    b.HasIndex("TeniskiKlubId");

                    b.ToTable("Teren");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Test10.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Test10.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Test10.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Test10.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Test10.Models.Oglas", b =>
                {
                    b.HasOne("Test10.Models.ApplicationUser", "Igrac")
                        .WithMany("Oglas")
                        .HasForeignKey("IgracId");

                    b.HasOne("Test10.Models.TeniskiKlub", "TeniskiKlub")
                        .WithMany("Oglas")
                        .HasForeignKey("TeniskiKlubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Test10.Models.Poruka", b =>
                {
                    b.HasOne("Test10.Models.ApplicationUser", "IgracPosiljatelj")
                        .WithMany("PorukaIgracPosiljatelj")
                        .HasForeignKey("IgracPosiljateljId");

                    b.HasOne("Test10.Models.ApplicationUser", "IgracPrimatelj")
                        .WithMany("PorukaIgracPrimatelj")
                        .HasForeignKey("IgracPrimateljId");
                });

            modelBuilder.Entity("Test10.Models.Rezervacija", b =>
                {
                    b.HasOne("Test10.Models.ApplicationUser", "Igrac")
                        .WithMany("RezervacijaIgrac")
                        .HasForeignKey("IgracId");

                    b.HasOne("Test10.Models.Teren", "Teren")
                        .WithMany("Rezervacija")
                        .HasForeignKey("TerenId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Test10.Models.ApplicationUser", "Upravitelj")
                        .WithMany("RezervacijaUpravitelj")
                        .HasForeignKey("UpraviteljId");
                });

            modelBuilder.Entity("Test10.Models.TeniskiKlub", b =>
                {
                    b.HasOne("Test10.Models.ApplicationUser", "Upravitelj")
                        .WithMany("TeniskiKlub")
                        .HasForeignKey("UpraviteljId");
                });

            modelBuilder.Entity("Test10.Models.Teren", b =>
                {
                    b.HasOne("Test10.Models.Podloga", "Podloga")
                        .WithMany("Teren")
                        .HasForeignKey("PodlogaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Test10.Models.TeniskiKlub", "TeniskiKlub")
                        .WithMany("Teren")
                        .HasForeignKey("TeniskiKlubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
