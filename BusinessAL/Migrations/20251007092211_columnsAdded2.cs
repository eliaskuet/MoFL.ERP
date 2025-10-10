using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessAL.Migrations
{
    /// <inheritdoc />
    public partial class columnsAdded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sequence",
                table: "Chairperson",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "Chairperson");
        }
    }
}
