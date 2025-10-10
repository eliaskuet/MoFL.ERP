using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessAL.Migrations
{
    /// <inheritdoc />
    public partial class columnsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChairPersonDesignation",
                table: "ConferenceRoomBooking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChairPersonName",
                table: "ConferenceRoomBooking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DesignationId",
                table: "Chairperson",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoogleEmail",
                table: "Chairperson",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Chairperson",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficialEmail",
                table: "Chairperson",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Chairperson",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chairperson_DesignationId",
                table: "Chairperson",
                column: "DesignationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chairperson_Designation_DesignationId",
                table: "Chairperson",
                column: "DesignationId",
                principalTable: "Designation",
                principalColumn: "DesignationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chairperson_Designation_DesignationId",
                table: "Chairperson");

            migrationBuilder.DropIndex(
                name: "IX_Chairperson_DesignationId",
                table: "Chairperson");

            migrationBuilder.DropColumn(
                name: "ChairPersonDesignation",
                table: "ConferenceRoomBooking");

            migrationBuilder.DropColumn(
                name: "ChairPersonName",
                table: "ConferenceRoomBooking");

            migrationBuilder.DropColumn(
                name: "DesignationId",
                table: "Chairperson");

            migrationBuilder.DropColumn(
                name: "GoogleEmail",
                table: "Chairperson");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Chairperson");

            migrationBuilder.DropColumn(
                name: "OfficialEmail",
                table: "Chairperson");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Chairperson");
        }
    }
}
