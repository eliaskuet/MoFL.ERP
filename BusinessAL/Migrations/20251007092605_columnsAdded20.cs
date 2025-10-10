using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessAL.Migrations
{
    /// <inheritdoc />
    public partial class columnsAdded20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 1,
                column: "Name",
                value: "উপদেষ্টা");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 2,
                column: "Name",
                value: "সচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 3,
                column: "Name",
                value: "অতিরিক্ত সচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 4,
                column: "Name",
                value: "যুগ্ম সচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 5,
                column: "Name",
                value: "উপসচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 6,
                column: "Name",
                value: "সিস্টেম এনালিস্ট");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 7,
                column: "Name",
                value: "সিনিয়র সহকারি সচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 8,
                column: "Name",
                value: "প্রোগ্রামার");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 9,
                column: "Name",
                value: "সহকারি সচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 10,
                column: "Name",
                value: "সহকারি প্রোগ্রামার");

            migrationBuilder.InsertData(
                table: "Designation",
                columns: new[] { "DesignationId", "IsPublished", "Name", "Order" },
                values: new object[] { 11, true, "হিসাব রক্ষণ কর্মকর্তা", 11 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 1,
                column: "Name",
                value: "সচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 2,
                column: "Name",
                value: "অতিরিক্ত সচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 3,
                column: "Name",
                value: "যুগ্ম সচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 4,
                column: "Name",
                value: "উপসচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 5,
                column: "Name",
                value: "সিস্টেম এনালিস্ট");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 6,
                column: "Name",
                value: "সিনিয়র সহকারি সচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 7,
                column: "Name",
                value: "প্রোগ্রামার");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 8,
                column: "Name",
                value: "সহকারি সচিব");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 9,
                column: "Name",
                value: "সহকারি প্রোগ্রামার");

            migrationBuilder.UpdateData(
                table: "Designation",
                keyColumn: "DesignationId",
                keyValue: 10,
                column: "Name",
                value: "হিসাব রক্ষণ কর্মকর্তা");
        }
    }
}
