using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingApi.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "WorkoutPlans");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExerciseId",
                table: "WorkoutPlans",
                nullable: false,
                defaultValue: 0);
        }
    }
}
