﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSportsAPI.Models;

#nullable disable

namespace WebSportsAPI.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20230508170151_Migrations")]
    partial class Migrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebSportsAPI.Models.Player", b =>
                {
                    b.Property<int>("Player_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Player_Id"));

                    b.Property<string>("PLayer_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Player_Age")
                        .HasColumnType("int");

                    b.Property<string>("Player_Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Player_Salary")
                        .HasColumnType("bigint");

                    b.Property<int>("Sport_Id")
                        .HasColumnType("int");

                    b.HasKey("Player_Id");

                    b.HasIndex("Sport_Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("WebSportsAPI.Models.Sport", b =>
                {
                    b.Property<int>("Sport_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sport_Id"));

                    b.Property<string>("End_Month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sport_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sport_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sport_Team_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sport_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Start_Month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sport_Id");

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("WebSportsAPI.Models.Player", b =>
                {
                    b.HasOne("WebSportsAPI.Models.Sport", "Sport")
                        .WithMany("Players")
                        .HasForeignKey("Sport_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sport");
                });

            modelBuilder.Entity("WebSportsAPI.Models.Sport", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
