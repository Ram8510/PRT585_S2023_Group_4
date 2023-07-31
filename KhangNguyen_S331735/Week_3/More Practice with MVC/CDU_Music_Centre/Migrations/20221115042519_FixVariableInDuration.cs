using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDUMusicLessonsApplication.Migrations
{
    /// <inheritdoc />
    public partial class FixVariableInDuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationCost",
                table: "Durations");

            migrationBuilder.RenameColumn(
                name: "Durationtype",
                table: "Durations",
                newName: "DurationTypeAndCost");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DurationTypeAndCost",
                table: "Durations",
                newName: "Durationtype");

            migrationBuilder.AddColumn<string>(
                name: "DurationCost",
                table: "Durations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
