using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingApi.Migrations
{
    public partial class azureDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoLibraries",
                keyColumn: "VideoLibraryId",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 2, 11, 19, 25, 30, 750, DateTimeKind.Local), new DateTime(2019, 2, 11, 19, 25, 30, 752, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VideoLibraries",
                keyColumn: "VideoLibraryId",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 2, 11, 19, 25, 30, 752, DateTimeKind.Local), new DateTime(2019, 2, 11, 19, 25, 30, 752, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VideoLibraries",
                keyColumn: "VideoLibraryId",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 2, 11, 19, 25, 30, 752, DateTimeKind.Local), new DateTime(2019, 2, 11, 19, 25, 30, 752, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoLibraries",
                keyColumn: "VideoLibraryId",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 2, 8, 14, 28, 34, 20, DateTimeKind.Local), new DateTime(2019, 2, 8, 14, 28, 34, 22, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VideoLibraries",
                keyColumn: "VideoLibraryId",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 2, 8, 14, 28, 34, 22, DateTimeKind.Local), new DateTime(2019, 2, 8, 14, 28, 34, 22, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VideoLibraries",
                keyColumn: "VideoLibraryId",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 2, 8, 14, 28, 34, 22, DateTimeKind.Local), new DateTime(2019, 2, 8, 14, 28, 34, 22, DateTimeKind.Local) });
        }
    }
}
