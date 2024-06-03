﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace olegity.Migrations.AboutDBContentMigrations
{
    /// <inheritdoc />
    public partial class fix22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "img",
                table: "AboutSections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img",
                table: "AboutSections");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "VideoAbout",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
