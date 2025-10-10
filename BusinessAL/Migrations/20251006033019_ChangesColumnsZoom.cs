using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessAL.Migrations
{
    /// <inheritdoc />
    public partial class ChangesColumnsZoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ZoomMeetingId",
                table: "ConferenceRoomBooking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZoomMeetingLink",
                table: "ConferenceRoomBooking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZoomMeetingPasscode",
                table: "ConferenceRoomBooking",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZoomMeetingId",
                table: "ConferenceRoomBooking");

            migrationBuilder.DropColumn(
                name: "ZoomMeetingLink",
                table: "ConferenceRoomBooking");

            migrationBuilder.DropColumn(
                name: "ZoomMeetingPasscode",
                table: "ConferenceRoomBooking");
        }
    }
}
