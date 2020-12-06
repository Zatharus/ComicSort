using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicSort.EntityFramework.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LibraryName = table.Column<string>(nullable: true),
                    LibraryPath = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastAccessed = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
