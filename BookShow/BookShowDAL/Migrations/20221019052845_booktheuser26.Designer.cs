﻿// <auto-generated />
using System;
using BookShowDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookShowDAL.Migrations
{
    [DbContext(typeof(BookShowDbContext))]
    [Migration("20221019052845_booktheuser26")]
    partial class booktheuser26
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BookShowEntity.BookTicket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<int?>("ShowTRimingId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShowTRimingId");

                    b.HasIndex("UserId");

                    b.ToTable("tblbook");
                });

            modelBuilder.Entity("BookShowEntity.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte[]>("ImgPoster")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("MovieDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("movies");
                });

            modelBuilder.Entity("BookShowEntity.ShowTiming", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShowTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TheatreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("TheatreId");

                    b.ToTable("showTiming");
                });

            modelBuilder.Entity("BookShowEntity.Theatre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("theatre");
                });

            modelBuilder.Entity("BookShowEntity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbluser");
                });

            modelBuilder.Entity("BookShowEntity.BookTicket", b =>
                {
                    b.HasOne("BookShowEntity.ShowTiming", "ShowTRiming")
                        .WithMany()
                        .HasForeignKey("ShowTRimingId");

                    b.HasOne("BookShowEntity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShowTRiming");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShowEntity.ShowTiming", b =>
                {
                    b.HasOne("BookShowEntity.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShowEntity.Theatre", "Theatre")
                        .WithMany()
                        .HasForeignKey("TheatreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Theatre");
                });
#pragma warning restore 612, 618
        }
    }
}
