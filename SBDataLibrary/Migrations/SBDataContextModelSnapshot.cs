﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SBDataLibrary.Server;

namespace SBDataLibrary.Migrations
{
    [DbContext(typeof(SBDataContext))]
    partial class SBDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SBDataLibrary.Models.Launch", b =>
                {
                    b.Property<string>("FlightId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("LaunchDate")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("MissionName")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Payloads")
                        .HasColumnType("int");

                    b.Property<string>("RocketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.ToTable("Launches");
                });

            modelBuilder.Entity("SBDataLibrary.Models.Rocket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LaunchID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Mass")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("RocketId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("LaunchID")
                        .IsUnique()
                        .HasFilter("[LaunchID] IS NOT NULL");

                    b.ToTable("Rockets");
                });

            modelBuilder.Entity("SBDataLibrary.Models.Ship", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HomePort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LaunchFlightId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Missions")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ShipId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("LaunchFlightId");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("SBDataLibrary.Models.Rocket", b =>
                {
                    b.HasOne("SBDataLibrary.Models.Launch", "Launch")
                        .WithOne("Rocket")
                        .HasForeignKey("SBDataLibrary.Models.Rocket", "LaunchID");
                });

            modelBuilder.Entity("SBDataLibrary.Models.Ship", b =>
                {
                    b.HasOne("SBDataLibrary.Models.Launch", "Launch")
                        .WithMany("Ships")
                        .HasForeignKey("LaunchFlightId");
                });
#pragma warning restore 612, 618
        }
    }
}
