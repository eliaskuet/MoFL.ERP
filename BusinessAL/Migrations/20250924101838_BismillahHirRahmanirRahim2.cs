using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessAL.Migrations
{
    /// <inheritdoc />
    public partial class BismillahHirRahmanirRahim2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TentativeEndTime",
                table: "ConferenceRoomBooking",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TentativeEndTime",
                table: "ConferenceRoomBooking",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
