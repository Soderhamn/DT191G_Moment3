﻿// <auto-generated />
using System;
using CdSamling.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CdSamling.Migrations.Cd
{
    [DbContext(typeof(CdContext))]
    [Migration("20230226122548_CdMigration")]
    partial class CdMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("CdSamling.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("CdSamling.Models.Cd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CdName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("NrTracks")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ReleaseYear")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Cd");
                });

            modelBuilder.Entity("CdSamling.Models.Cd", b =>
                {
                    b.HasOne("CdSamling.Models.Artist", "Artist")
                        .WithMany("Cds")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("CdSamling.Models.Artist", b =>
                {
                    b.Navigation("Cds");
                });
#pragma warning restore 612, 618
        }
    }
}
