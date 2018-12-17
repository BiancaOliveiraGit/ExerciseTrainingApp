using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingApi.Migrations
{
    public partial class newField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "WorkoutPlans",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseId",
                table: "Exercises",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ClientExerciseId",
                table: "ClientWorkouts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ClientExerciseId",
                table: "ClientExercises",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_ClientWorkouts_WorkoutPlanId",
                table: "ClientWorkouts",
                column: "WorkoutPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientExercises_ExerciseId",
                table: "ClientExercises",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientExercises_ClientWorkouts_ClientExerciseId",
                table: "ClientExercises",
                column: "ClientExerciseId",
                principalTable: "ClientWorkouts",
                principalColumn: "ClientWorkoutId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientExercises_Exercises_ExerciseId",
                table: "ClientExercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "ExerciseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientWorkouts_WorkoutPlans_WorkoutPlanId",
                table: "ClientWorkouts",
                column: "WorkoutPlanId",
                principalTable: "WorkoutPlans",
                principalColumn: "WorkoutPlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_WorkoutExercises_ExerciseId",
                table: "Exercises",
                column: "ExerciseId",
                principalTable: "WorkoutExercises",
                principalColumn: "WorkoutExerciseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientExercises_ClientWorkouts_ClientExerciseId",
                table: "ClientExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientExercises_Exercises_ExerciseId",
                table: "ClientExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientWorkouts_WorkoutPlans_WorkoutPlanId",
                table: "ClientWorkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_WorkoutExercises_ExerciseId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_ClientWorkouts_WorkoutPlanId",
                table: "ClientWorkouts");

            migrationBuilder.DropIndex(
                name: "IX_ClientExercises_ExerciseId",
                table: "ClientExercises");

            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "WorkoutPlans");

            migrationBuilder.DropColumn(
                name: "ClientExerciseId",
                table: "ClientWorkouts");

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseId",
                table: "Exercises",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ClientExerciseId",
                table: "ClientExercises",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}
