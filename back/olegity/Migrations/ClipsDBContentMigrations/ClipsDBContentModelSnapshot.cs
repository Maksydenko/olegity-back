﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using olegity.Data;

#nullable disable

namespace olegity.Migrations.ClipsDBContentMigrations
{
    [DbContext(typeof(ClipsDBContent))]
    partial class ClipsDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("olegity.Data.Models.Clips", b =>
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

                    b.ToTable("Clips");
                });

            modelBuilder.Entity("olegity.Data.Models.VideoClips", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("musicVideosID")
                        .HasColumnType("int");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("musicVideosID");

                    b.ToTable("VideoClips");
                });

            modelBuilder.Entity("olegity.Data.Models.VideoClips", b =>
                {
                    b.HasOne("olegity.Data.Models.Clips", "Clips")
                        .WithMany("Video")
                        .HasForeignKey("musicVideosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clips");
                });

            modelBuilder.Entity("olegity.Data.Models.Clips", b =>
                {
                    b.Navigation("Video");
                });
#pragma warning restore 612, 618
        }
    }
}
