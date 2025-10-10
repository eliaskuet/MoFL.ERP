using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessAL.Migrations
{
    /// <inheritdoc />
    public partial class ChangesColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactPersonMobile",
                table: "ConferenceRoomBooking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonaName",
                table: "ConferenceRoomBooking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeOrderUrl",
                table: "ConferenceRoomBooking",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactPersonMobile",
                table: "ConferenceRoomBooking");

            migrationBuilder.DropColumn(
                name: "ContactPersonaName",
                table: "ConferenceRoomBooking");

            migrationBuilder.DropColumn(
                name: "OfficeOrderUrl",
                table: "ConferenceRoomBooking");
        }
    }
}
