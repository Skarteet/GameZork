﻿// <auto-generated />
using System;
using GameZork.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameZork.DataAccessLayer.Migrations
{
    [DbContext(typeof(GameZorkDbContext))]
    partial class GameZorkDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameZork.DataAccessLayer.Models.Cell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MapId")
                        .HasColumnType("int");

                    b.Property<int>("PosX")
                        .HasColumnType("int");

                    b.Property<int>("PosY")
                        .HasColumnType("int");

                    b.Property<bool>("canMoveTo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MapId");

                    b.ToTable("Cell");
                });

            modelBuilder.Entity("GameZork.DataAccessLayer.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AttackBoost")
                        .HasColumnType("int");

                    b.Property<int?>("DefenseBoost")
                        .HasColumnType("int");

                    b.Property<int?>("HpRestoreValue")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("GameZork.DataAccessLayer.Models.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Map");
                });

            modelBuilder.Entity("GameZork.DataAccessLayer.Models.Monster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("HP")
                        .HasColumnType("int");

                    b.Property<int>("MaxHP")
                        .HasColumnType("int");

                    b.Property<int>("MissRate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Monster");
                });

            modelBuilder.Entity("GameZork.DataAccessLayer.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CellId")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("HP")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("MapId")
                        .HasColumnType("int");

                    b.Property<int>("MaxHP")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NextLevelXpRequired")
                        .HasColumnType("int");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<int>("XP")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CellId");

                    b.HasIndex("MapId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("GameZork.DataAccessLayer.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<int>("MissRate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("ItemPlayer", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("PlayersId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "PlayersId");

                    b.HasIndex("PlayersId");

                    b.ToTable("ItemPlayer");
                });

            modelBuilder.Entity("PlayerWeapon", b =>
                {
                    b.Property<int>("PlayersId")
                        .HasColumnType("int");

                    b.Property<int>("WeaponsId")
                        .HasColumnType("int");

                    b.HasKey("PlayersId", "WeaponsId");

                    b.HasIndex("WeaponsId");

                    b.ToTable("PlayerWeapon");
                });

            modelBuilder.Entity("GameZork.DataAccessLayer.Models.Cell", b =>
                {
                    b.HasOne("GameZork.DataAccessLayer.Models.Map", null)
                        .WithMany("Cells")
                        .HasForeignKey("MapId");
                });

            modelBuilder.Entity("GameZork.DataAccessLayer.Models.Player", b =>
                {
                    b.HasOne("GameZork.DataAccessLayer.Models.Cell", "Cell")
                        .WithMany()
                        .HasForeignKey("CellId");

                    b.HasOne("GameZork.DataAccessLayer.Models.Map", "Map")
                        .WithMany()
                        .HasForeignKey("MapId");

                    b.Navigation("Cell");

                    b.Navigation("Map");
                });

            modelBuilder.Entity("ItemPlayer", b =>
                {
                    b.HasOne("GameZork.DataAccessLayer.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameZork.DataAccessLayer.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlayerWeapon", b =>
                {
                    b.HasOne("GameZork.DataAccessLayer.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameZork.DataAccessLayer.Models.Weapon", null)
                        .WithMany()
                        .HasForeignKey("WeaponsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameZork.DataAccessLayer.Models.Map", b =>
                {
                    b.Navigation("Cells");
                });
#pragma warning restore 612, 618
        }
    }
}
