﻿// <auto-generated />
using System;
using DungeonHeros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DungeonHeros.Migrations
{
    [DbContext(typeof(DungeonHerosDbContext))]
    [Migration("20220523045255_LastOne")]
    partial class LastOne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DungeonHeros.Models.Dungeon", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dungeon", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Image = "/Images/cover.jpg",
                            Level = 24,
                            Name = "Les Terres Brules"
                        },
                        new
                        {
                            Id = "2",
                            Image = "/Images/IceDJ.jpg",
                            Level = 42,
                            Name = "Cours du hibou"
                        },
                        new
                        {
                            Id = "3",
                            Image = "/Images/Desert.jpg",
                            Level = 55,
                            Name = "Temple de hrakas"
                        },
                        new
                        {
                            Id = "4",
                            Image = "/Images/Forest.jpg",
                            Level = 10,
                            Name = "Foret celeste"
                        });
                });

            modelBuilder.Entity("DungeonHeros.Models.DungeonMonstreRelation", b =>
                {
                    b.Property<string>("DungeonsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MonstresNom")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NbrMonstre")
                        .HasColumnType("int");

                    b.HasKey("DungeonsId", "MonstresNom");

                    b.ToTable("DungeonMonstre", (string)null);

                    b.HasData(
                        new
                        {
                            DungeonsId = "1",
                            MonstresNom = "Kobold",
                            NbrMonstre = 5
                        },
                        new
                        {
                            DungeonsId = "1",
                            MonstresNom = "Ogre",
                            NbrMonstre = 2
                        },
                        new
                        {
                            DungeonsId = "1",
                            MonstresNom = "Golem d’os",
                            NbrMonstre = 1
                        },
                        new
                        {
                            DungeonsId = "1",
                            MonstresNom = "Serwaul",
                            NbrMonstre = 1
                        },
                        new
                        {
                            DungeonsId = "2",
                            MonstresNom = "Efrit",
                            NbrMonstre = 2
                        },
                        new
                        {
                            DungeonsId = "2",
                            MonstresNom = "Fafnir",
                            NbrMonstre = 1
                        },
                        new
                        {
                            DungeonsId = "2",
                            MonstresNom = "Hydre",
                            NbrMonstre = 1
                        },
                        new
                        {
                            DungeonsId = "2",
                            MonstresNom = "Vouivre",
                            NbrMonstre = 2
                        },
                        new
                        {
                            DungeonsId = "3",
                            MonstresNom = "Dark Lord",
                            NbrMonstre = 1
                        },
                        new
                        {
                            DungeonsId = "3",
                            MonstresNom = "Serwaul",
                            NbrMonstre = 5
                        },
                        new
                        {
                            DungeonsId = "4",
                            MonstresNom = "Araignée",
                            NbrMonstre = 2
                        },
                        new
                        {
                            DungeonsId = "4",
                            MonstresNom = "Chauve - Souris",
                            NbrMonstre = 2
                        },
                        new
                        {
                            DungeonsId = "4",
                            MonstresNom = "Loup Geant",
                            NbrMonstre = 1
                        });
                });

            modelBuilder.Entity("DungeonHeros.Models.Hero", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Classe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Endurance")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Force")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Placeholder_hero.jpg");

                    b.Property<double>("Lvl")
                        .HasColumnType("float");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hero", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Classe = "Magicien",
                            Endurance = 5,
                            Force = 2,
                            Image = "/Images/nainVoleur.jpg",
                            Lvl = 5.0,
                            Nom = "Torain",
                            Race = "Nain",
                            UserID = "2"
                        },
                        new
                        {
                            Id = "2",
                            Classe = "Guerrier",
                            Endurance = 2,
                            Force = 5,
                            Image = "/Images/orcGuerrier.jpg",
                            Lvl = 3.0,
                            Nom = "Gurldac",
                            Race = "Orc",
                            UserID = "2"
                        },
                        new
                        {
                            Id = "3",
                            Classe = "Archer",
                            Endurance = 4,
                            Force = 3,
                            Image = "/Images/elfeArcher.jpg",
                            Lvl = 2.0,
                            Nom = "Oldin",
                            Race = "Elf",
                            UserID = "2"
                        },
                        new
                        {
                            Id = "4",
                            Classe = "Voleur",
                            Endurance = 6,
                            Force = 1,
                            Image = "/Images/humainSorcier.jpg",
                            Lvl = 5.0,
                            Nom = "Didier",
                            Race = "Humain",
                            UserID = "2"
                        },
                        new
                        {
                            Id = "5",
                            Classe = "Voleur",
                            Endurance = 2,
                            Force = 4,
                            Image = "/Images/nainVoleur.jpg",
                            Lvl = 3.0,
                            Nom = "Gibli",
                            Race = "Nain",
                            UserID = "3"
                        },
                        new
                        {
                            Id = "6",
                            Classe = "Archer",
                            Endurance = 1,
                            Force = 6,
                            Image = "/Images/orcGuerrier.jpg",
                            Lvl = 4.5,
                            Nom = "Gorduc",
                            Race = "Orc",
                            UserID = "3"
                        },
                        new
                        {
                            Id = "7",
                            Classe = "Guerrier",
                            Endurance = 3,
                            Force = 2,
                            Image = "/Images/elfeArcher.jpg",
                            Lvl = 5.0,
                            Nom = "Aldin",
                            Race = "Elf",
                            UserID = "4"
                        });
                });

            modelBuilder.Entity("DungeonHeros.Models.HeroTeamRelation", b =>
                {
                    b.Property<string>("HeroesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeamsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("HeroesId", "TeamsId");

                    b.ToTable("HeroTeam", (string)null);

                    b.HasData(
                        new
                        {
                            HeroesId = "1",
                            TeamsId = "7"
                        },
                        new
                        {
                            HeroesId = "2",
                            TeamsId = "7"
                        },
                        new
                        {
                            HeroesId = "3",
                            TeamsId = "7"
                        },
                        new
                        {
                            HeroesId = "4",
                            TeamsId = "7"
                        },
                        new
                        {
                            HeroesId = "5",
                            TeamsId = "9"
                        },
                        new
                        {
                            HeroesId = "6",
                            TeamsId = "9"
                        },
                        new
                        {
                            HeroesId = "7",
                            TeamsId = "8"
                        });
                });

            modelBuilder.Entity("DungeonHeros.Models.Monstre", b =>
                {
                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Endurance")
                        .HasColumnType("int");

                    b.Property<int>("Force")
                        .HasColumnType("int");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nom");

                    b.ToTable("Monster", (string)null);

                    b.HasData(
                        new
                        {
                            Nom = "Araignée",
                            Avatar = "/Images/Monstre/spider.png",
                            Endurance = 2,
                            Force = 2,
                            Race = "Animal"
                        },
                        new
                        {
                            Nom = "Chauve - Souris",
                            Avatar = "/Images/Monstre/bat.png",
                            Endurance = 2,
                            Force = 1,
                            Race = "Animal"
                        },
                        new
                        {
                            Nom = "Dark Lord",
                            Avatar = "/Images/Monstre/DarkLord.png",
                            Endurance = 20,
                            Force = 20,
                            Race = "Démon"
                        },
                        new
                        {
                            Nom = "Efrit",
                            Avatar = "/Images/Monstre/efrit.png",
                            Endurance = 4,
                            Force = 4,
                            Race = "Monstre"
                        },
                        new
                        {
                            Nom = "Fafnir",
                            Avatar = "/Images/Monstre/Fafnir.png",
                            Endurance = 7,
                            Force = 9,
                            Race = "Dragon"
                        },
                        new
                        {
                            Nom = "Golem d’os",
                            Avatar = "/Images/Monstre/Bone_Golem.jpg",
                            Endurance = 3,
                            Force = 5,
                            Race = "Monstre"
                        },
                        new
                        {
                            Nom = "Grougaloragran",
                            Avatar = "/Images/Monstre/grougaloragran.png",
                            Endurance = 12,
                            Force = 4,
                            Race = "Dragon"
                        },
                        new
                        {
                            Nom = "Hydre",
                            Avatar = "/Images/Monstre/hydra.png",
                            Endurance = 11,
                            Force = 5,
                            Race = "Monstre"
                        },
                        new
                        {
                            Nom = "Kobold",
                            Avatar = "/Images/Monstre/kobold.png",
                            Endurance = 4,
                            Force = 2,
                            Race = "Monstre"
                        },
                        new
                        {
                            Nom = "Loup Geant",
                            Avatar = "/Images/Monstre/wolf.png",
                            Endurance = 3,
                            Force = 4,
                            Race = "Animal"
                        },
                        new
                        {
                            Nom = "Ogre",
                            Avatar = "/Images/Monstre/ogre.png",
                            Endurance = 3,
                            Force = 1,
                            Race = "Monstre"
                        },
                        new
                        {
                            Nom = "Serwaul",
                            Avatar = "/Images/Monstre/serwaul.png",
                            Endurance = 1,
                            Force = 7,
                            Race = "Démon"
                        },
                        new
                        {
                            Nom = "Vouivre",
                            Avatar = "/Images/Monstre/wyvern.png",
                            Endurance = 15,
                            Force = 10,
                            Race = "Dragon"
                        });
                });

            modelBuilder.Entity("DungeonHeros.Models.Team", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Teams", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Score = 0,
                            UserId = "5"
                        },
                        new
                        {
                            Id = "2",
                            Score = 15,
                            UserId = "5"
                        },
                        new
                        {
                            Id = "3",
                            Score = 10,
                            UserId = "5"
                        },
                        new
                        {
                            Id = "4",
                            Score = 10,
                            UserId = "5"
                        },
                        new
                        {
                            Id = "5",
                            Score = 5,
                            UserId = "5"
                        },
                        new
                        {
                            Id = "6",
                            Score = 20,
                            UserId = "5"
                        },
                        new
                        {
                            Id = "7",
                            Score = 45,
                            UserId = "2"
                        },
                        new
                        {
                            Id = "8",
                            Score = 25,
                            UserId = "4"
                        },
                        new
                        {
                            Id = "9",
                            Score = 30,
                            UserId = "3"
                        });
                });

            modelBuilder.Entity("DungeonHeros.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NomHero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4851d78b-db96-4f59-997d-64a94bc84014",
                            DateOfBirth = new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ghostkiller598r@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NomHero = "Ghostkiller",
                            NormalizedEmail = "GHOSTKILLER598R@GMAIL.COM",
                            NormalizedUserName = "GHOSTKILLER",
                            PasswordHash = "AQAAAAEAACcQAAAAELY3l7KMPJBYl7Z0Fngt/XCak4QhuAWfJgf5qJHVqrpZ4A1sBs3YQLwSiZO+L15bsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "98107cc2-01c9-400a-97ad-a1bcc8917bc3",
                            TwoFactorEnabled = false,
                            UserName = "Ghostkiller"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7aa9f3d7-d42d-4a76-99fc-e5ddcceeb392",
                            DateOfBirth = new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nathanlombardelli@hotmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NomHero = "Ghost",
                            NormalizedEmail = "NATHANLOMBARDELLI@HOTMAIL.COM",
                            NormalizedUserName = "GHOST",
                            PasswordHash = "AQAAAAEAACcQAAAAELY3l7KMPJBYl7Z0Fngt/XCak4QhuAWfJgf5qJHVqrpZ4A1sBs3YQLwSiZO+L15bsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4042cfc8-e5a0-4afe-a43e-b0565525e896",
                            TwoFactorEnabled = false,
                            UserName = "Ghost"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9782b4f5-5a3c-40cf-b25a-33c1703fc09f",
                            DateOfBirth = new DateTime(1980, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fabriceetverodehous@hotmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NomHero = "LOU",
                            NormalizedEmail = "FABRICEETVERODEHOUS@HOTMAIL.COM",
                            NormalizedUserName = "LOU",
                            PasswordHash = "AQAAAAEAACcQAAAAELY3l7KMPJBYl7Z0Fngt/XCak4QhuAWfJgf5qJHVqrpZ4A1sBs3YQLwSiZO+L15bsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7ed4d951-909a-440b-b378-e6aa45dd6525",
                            TwoFactorEnabled = false,
                            UserName = "LOU"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "489cfa5b-168d-457f-9285-7a875d5b3660",
                            DateOfBirth = new DateTime(1982, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "dejardinveronique.b159@hotmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NomHero = "Icare",
                            NormalizedEmail = "DEJARDINVERONIQUE.B159@HOTMAIL.COM",
                            NormalizedUserName = "ICARE",
                            PasswordHash = "AQAAAAEAACcQAAAAELY3l7KMPJBYl7Z0Fngt/XCak4QhuAWfJgf5qJHVqrpZ4A1sBs3YQLwSiZO+L15bsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f81de9ad-5c68-41c3-8525-5f2c090e7349",
                            TwoFactorEnabled = false,
                            UserName = "Icare"
                        },
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "438fdd42-d8d4-4175-8c53-e48b841a1f94",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@hotmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NomHero = "admin",
                            NormalizedEmail = "ADMIN@HOTMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAELY3l7KMPJBYl7Z0Fngt/XCak4QhuAWfJgf5qJHVqrpZ4A1sBs3YQLwSiZO+L15bsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1020b661-5f87-4d31-af23-7d667c52cc50",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DungeonHeros.Models.Team", b =>
                {
                    b.HasOne("DungeonHeros.Models.User", null)
                        .WithMany("Teams")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DungeonHeros.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DungeonHeros.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonHeros.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DungeonHeros.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DungeonHeros.Models.User", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
