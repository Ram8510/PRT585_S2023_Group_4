using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDUMusicLessonsApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddDurationDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DurationDescription",
                table: "Durations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationDescription",
                table: "Durations");
        }
    }
}
