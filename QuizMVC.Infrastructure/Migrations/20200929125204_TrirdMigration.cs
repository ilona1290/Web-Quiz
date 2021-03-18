using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizMVC.Infrastructure.Migrations
{
    public partial class TrirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BadAnswersToQuestions");

            migrationBuilder.DropTable(
                name: "GoodAnswerToQuestions");

            migrationBuilder.AddColumn<string>(
                name: "CategoryText",
                table: "Questions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerText = table.Column<int>(nullable: false),
                    IsCorrect = table.Column<bool>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropColumn(
                name: "CategoryText",
                table: "Questions");

            migrationBuilder.CreateTable(
                name: "BadAnswersToQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BadAnswer1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BadAnswer2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BadAnswer3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BadAnswersToQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BadAnswersToQuestions_Questions_QuestionRef",
                        column: x => x.QuestionRef,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoodAnswerToQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodAnswerToQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoodAnswerToQuestions_Questions_QuestionRef",
                        column: x => x.QuestionRef,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BadAnswersToQuestions_QuestionRef",
                table: "BadAnswersToQuestions",
                column: "QuestionRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GoodAnswerToQuestions_QuestionRef",
                table: "GoodAnswerToQuestions",
                column: "QuestionRef",
                unique: true);
        }
    }
}
