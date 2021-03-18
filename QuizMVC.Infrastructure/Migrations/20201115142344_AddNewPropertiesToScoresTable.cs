using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizMVC.Infrastructure.Migrations
{
    public partial class AddNewPropertiesToScoresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Result",
                table: "Scores");

            migrationBuilder.AddColumn<int>(
                name: "BestResult",
                table: "Scores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentResult",
                table: "Scores",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BestResult",
                table: "Scores");

            migrationBuilder.DropColumn(
                name: "CurrentResult",
                table: "Scores");

            migrationBuilder.AddColumn<int>(
                name: "Result",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
