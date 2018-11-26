using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingApi.Migrations
{
    public partial class AllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "Clients",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "Mobile",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "VideoLibraries",
                columns: table => new
                {
                    VideoLibraryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VideoUrl = table.Column<string>(nullable: true),
                    AltTag = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    DoNotUse = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoLibraries", x => x.VideoLibraryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoLibraries");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Clients",
                newName: "TrainerId");
        }
    }
}
