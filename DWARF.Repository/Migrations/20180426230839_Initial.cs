using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DWARF.Repository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ApplicationName = table.Column<string>(nullable: true),
                    Thread = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Exception = table.Column<string>(nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");
        }
    }
}
