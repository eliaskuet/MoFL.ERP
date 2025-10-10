using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessAL.Migrations
{
    /// <inheritdoc />
    public partial class FileExtensionColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "Document",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "Document");
        }
    }
}
