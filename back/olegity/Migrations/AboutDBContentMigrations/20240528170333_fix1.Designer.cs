﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using olegity.Data;

#nullable disable

namespace olegity.Migrations.AboutDBContentMigrations
{
    [DbContext(typeof(AboutDBContent))]
    [Migration("20240528170333_fix1")]
    partial class fix1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("olegity.Data.Models.AboutSections", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pageID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("AboutSections");
                });

            modelBuilder.Entity("olegity.Data.Models.TranslationsAbout", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AboutSectionsID")
                        .HasColumnType("int");

                    b.Property<int>("sectionID")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("translation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AboutSectionsID");

                    b.ToTable("TranslationsAbout");
                });

            modelBuilder.Entity("olegity.Data.Models.TranslationsAbout", b =>
                {
                    b.HasOne("olegity.Data.Models.AboutSections", "AboutSections")
                        .WithMany("Translations")
                        .HasForeignKey("AboutSectionsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AboutSections");
                });

            modelBuilder.Entity("olegity.Data.Models.AboutSections", b =>
                {
                    b.Navigation("Translations");
                });
#pragma warning restore 612, 618
        }
    }
}
