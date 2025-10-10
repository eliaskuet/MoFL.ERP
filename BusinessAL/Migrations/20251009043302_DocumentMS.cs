using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessAL.Migrations
{
    /// <inheritdoc />
    public partial class DocumentMS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentCategory",
                columns: table => new
                {
                    DocumentCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentCategory", x => x.DocumentCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "FileType",
                columns: table => new
                {
                    FileTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileType", x => x.FileTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: true),
                    OfficeId = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Document_DocumentCategory_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentCategory",
                        principalColumn: "DocumentCategoryId");
                    table.ForeignKey(
                        name: "FK_Document_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DocumentCategory",
                columns: new[] { "DocumentCategoryId", "CategoryName", "CreatedByUserId", "CreatedDate", "Description", "IsPublished", "ModifiedById", "ModificationDate" },
                values: new object[,]
                {
                    { 1, "চিঠি", 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200), "সরকারি বা ব্যক্তিগত চিঠিপত্র", true, 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200) },
                    { 2, "রিপোর্ট", 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200), "বিভিন্ন ধরনের রিপোর্ট", true, 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200) },
                    { 3, "ফর্ম", 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200), "আবেদন ফর্ম বা অন্যান্য ফর্ম", true, 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200) },
                    { 4, "প্রেজেন্টেশন", 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200), "PowerPoint বা অন্যান্য প্রেজেন্টেশন ফাইল", true, 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200) },
                    { 5, "মেমো", 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200), "মেমো বা নোটিশ", true, 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200) },
                    { 6, "অন্যান্য", 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200), "অন্যান্য ধরনের ডকুমেন্ট", true, 1, new DateTime(2024, 10, 9, 10, 33, 2, 123, DateTimeKind.Utc).AddTicks(9200) }
                    });

            migrationBuilder.InsertData(
                table: "FileType",
                columns: new[] { "FileTypeId", "Description", "FileExtension", "IsPublished", "TypeName" },
                values: new object[,]
                {
                    { 1, "Portable Document Format", ".pdf", true, "PDF" },
                    { 2, "Microsoft Word Document", ".docx", true, "Word Document" },
                    { 3, "Microsoft Excel Spreadsheet", ".xlsx", true, "Excel Spreadsheet" },
                    { 4, "Microsoft PowerPoint Presentation", ".pptx", true, "PowerPoint Presentation" },
                    { 5, "Plain Text File", ".txt", true, "Text File" },
                    { 6, "Image Files (JPEG, PNG, GIF)", ".jpg/.png/.gif", true, "Image File" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentTypeId",
                table: "Document",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_OfficeId",
                table: "Document",
                column: "OfficeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "FileType");

            migrationBuilder.DropTable(
                name: "DocumentCategory");
        }
    }
}
