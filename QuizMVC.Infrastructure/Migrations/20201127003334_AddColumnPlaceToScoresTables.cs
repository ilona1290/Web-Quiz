using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizMVC.Infrastructure.Migrations
{
    public partial class AddColumnPlaceToScoresTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Place",
                table: "Scores",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "Scores");
        }
    }
}
