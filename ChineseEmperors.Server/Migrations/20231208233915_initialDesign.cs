using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChineseEmperors.Server.Migrations
{
    /// <inheritdoc />
    public partial class initialDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChineseEmperors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NickName = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    EraName = table.Column<string>(type: "text", nullable: true),
                    TempleName = table.Column<string>(type: "text", nullable: true),
                    PosthumousName = table.Column<string>(type: "text", nullable: true),
                    CauseOfDeath = table.Column<string>(type: "text", nullable: true),
                    BirthYear = table.Column<int>(type: "integer", nullable: true),
                    DeathYear = table.Column<int>(type: "integer", nullable: true),
                    ReignStartYear = table.Column<int>(type: "integer", nullable: true),
                    ReignEndYear = table.Column<int>(type: "integer", nullable: true),
                    Bio = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    FatherId = table.Column<int>(type: "integer", nullable: true),
                    SuccessorId = table.Column<int>(type: "integer", nullable: true),
                    PredecessorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChineseEmperors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChineseEmperors_ChineseEmperors_FatherId",
                        column: x => x.FatherId,
                        principalTable: "ChineseEmperors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChineseEmperors_ChineseEmperors_SuccessorId",
                        column: x => x.SuccessorId,
                        principalTable: "ChineseEmperors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChineseEmperors_FatherId",
                table: "ChineseEmperors",
                column: "FatherId");

            migrationBuilder.CreateIndex(
                name: "IX_ChineseEmperors_SuccessorId",
                table: "ChineseEmperors",
                column: "SuccessorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChineseEmperors");
        }
    }
}
