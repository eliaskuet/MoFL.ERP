using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessAL.Migrations
{
    /// <inheritdoc />
    public partial class BismillahHirRahmanirRahim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NothiId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chairperson",
                columns: table => new
                {
                    ChairpersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChairpersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chairperson", x => x.ChairpersonId);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CountryTicker = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    PhoneCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Degree",
                columns: table => new
                {
                    DegreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => x.DegreeId);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    DesignationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.DesignationId);
                });

            migrationBuilder.CreateTable(
                name: "EventType",
                columns: table => new
                {
                    EventTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventType", x => x.EventTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    OfficeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Moto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiveUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCurrentOffice = table.Column<bool>(type: "bit", nullable: false),
                    ParentOfficeId = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.OfficeId);
                    table.ForeignKey(
                        name: "FK_Office_Office_ParentOfficeId",
                        column: x => x.ParentOfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeId");
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.SectionId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    StateTicker = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConferenceRoomBooking",
                columns: table => new
                {
                    ConferenceRoomBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChairpersonId = table.Column<int>(type: "int", nullable: false),
                    TentativeEndTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeId = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConferenceRoomBooking", x => x.ConferenceRoomBookingId);
                    table.ForeignKey(
                        name: "FK_ConferenceRoomBooking_Chairperson_ChairpersonId",
                        column: x => x.ChairpersonId,
                        principalTable: "Chairperson",
                        principalColumn: "ChairpersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConferenceRoomBooking_EventType_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventType",
                        principalColumn: "EventTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConferenceRoomBooking_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locality",
                columns: table => new
                {
                    LocalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locality", x => x.LocalityId);
                    table.ForeignKey(
                        name: "FK_Locality_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "CountryTicker", "IsPublished", "Name", "PhoneCode" },
                values: new object[,]
                {
                    { 1, "BD", true, "বাংলাদেশ", null },
                    { 2, "GB", true, "United Kingdom", null },
                    { 3, "AE", true, "United Arab Emirates", null },
                    { 4, "SZ", true, "Swaziland", null },
                    { 5, "IN", true, "India", null },
                    { 6, "FR", true, "France", null },
                    { 7, "CA", true, "Canada", null },
                    { 8, "AU", true, "Australia", null },
                    { 9, "CN", true, "China", null },
                    { 10, "DE", true, "Germany", null },
                    { 11, "AT", true, "Austria", null },
                    { 12, "AZ", true, "Azerbaijan", null },
                    { 13, "BS", true, "Bahamas", null },
                    { 14, "BH", true, "Bahrain", null },
                    { 15, "US", true, "United States", null },
                    { 16, "BB", true, "Barbados", null },
                    { 17, "BY", true, "Belarus", null },
                    { 18, "BE", true, "Belgium", null },
                    { 19, "BZ", true, "Belize", null },
                    { 20, "BJ", true, "Benin", null },
                    { 21, "BM", true, "Bermuda", null },
                    { 22, "BT", true, "Bhutan", null },
                    { 23, "BO", true, "Bolivia", null },
                    { 24, "BA", true, "Bosnia and Herzegovina", null },
                    { 25, "BW", true, "Botswana", null },
                    { 26, "BV", true, "Bouvet Island", null },
                    { 27, "BR", true, "Brazil", null },
                    { 28, "VG", true, "British Virgin Islands", null },
                    { 29, "BN", true, "Brunei Darussalam", null },
                    { 30, "BG", true, "Bulgaria", null },
                    { 31, "BF", true, "Burkina Faso", null },
                    { 32, "BI", true, "Burundi", null },
                    { 33, "KH", true, "Cambodia", null },
                    { 34, "CM", true, "Cameroon", null },
                    { 35, "CV", true, "Cape Verde", null },
                    { 36, "KY", true, "Cayman Islands", null },
                    { 37, "CF", true, "Central African Republic", null },
                    { 38, "TD", true, "Chad", null },
                    { 39, "CL", true, "Chile", null },
                    { 40, "CO", true, "Colombia", null },
                    { 41, "KM", true, "Comoros", null },
                    { 42, "CG", true, "Congo", null },
                    { 43, "CK", true, "Cook Islands", null },
                    { 44, "CR", true, "Costa Rica", null },
                    { 45, "CI", true, "Cote d'Ivoire", null },
                    { 46, "HR", true, "Croatia", null },
                    { 47, "CU", true, "Cuba", null },
                    { 48, "CY", true, "Cyprus", null },
                    { 49, "CZ", true, "Czech Republic", null },
                    { 50, "DK", true, "Denmark", null },
                    { 51, "DJ", true, "Djibouti", null },
                    { 52, "DM", true, "Dominica", null },
                    { 53, "DO", true, "Dominican Republic", null },
                    { 54, "TL", true, "East Timor", null },
                    { 55, "EC", true, "Ecuador", null },
                    { 56, "EG", true, "Egypt", null },
                    { 57, "SV", true, "El Salvador", null },
                    { 58, "GQ", true, "Equatorial Guinea", null },
                    { 59, "ER", true, "Eritrea", null },
                    { 60, "EE", true, "Estonia", null },
                    { 61, "ET", true, "Ethiopia", null },
                    { 62, "EKV", true, "Europe	Kosovo", null },
                    { 63, "FO", true, "Faeroe Islands", null },
                    { 64, "FJ", true, "Fiji", null },
                    { 65, "FI", true, "Finland", null },
                    { 66, "FX", true, "France Metropolitan", null },
                    { 67, "GF", true, "French Guiana", null },
                    { 68, "PF", true, "French Polynesia", null },
                    { 69, "GA", true, "Gabon", null },
                    { 70, "GM", true, "Gambia", null },
                    { 71, "HT", true, "Haiti", null },
                    { 72, "HN", true, "Honduras", null },
                    { 73, "HK", true, "Hong Kong", null },
                    { 74, "HU", true, "Hungary", null },
                    { 75, "IS", true, "Iceland", null },
                    { 76, "ID", true, "Indonesia", null },
                    { 77, "IR", true, "Iran", null },
                    { 78, "IQ", true, "Iraq", null },
                    { 79, "IE", true, "Ireland", null },
                    { 80, "IL", true, "Israel", null },
                    { 81, "IT", true, "Italy", null },
                    { 82, "JM", true, "Jamaica", null },
                    { 83, "JP", true, "Japan", null },
                    { 84, "JO", true, "Jordan", null },
                    { 85, "KZ", true, "Kazakhstan", null },
                    { 86, "KE", true, "Kenya", null },
                    { 87, "KI", true, "Kiribati", null },
                    { 88, "KW", true, "Kuwait", null },
                    { 89, "KG", true, "Kyrgyzstan", null },
                    { 90, "LO", true, "Laos", null },
                    { 91, "LV", true, "Latvia", null },
                    { 92, "LB", true, "Lebanon", null },
                    { 93, "LS", true, "Lesotho", null },
                    { 94, "LR", true, "Liberia", null },
                    { 95, "LY", true, "Libya", null },
                    { 96, "LI", true, "Liechtenstein", null },
                    { 97, "LT", true, "Lithuania", null },
                    { 98, "LU", true, "Luxembourg", null },
                    { 99, "MO", true, "Macao", null },
                    { 100, "MK", true, "Macedonia", null },
                    { 101, "MG", true, "Madagascar", null },
                    { 102, "MW", true, "Malawi", null },
                    { 103, "MY", true, "Malaysia", null },
                    { 104, "MV", true, "Maldives", null },
                    { 105, "ML", true, "Mali", null },
                    { 106, "MT", true, "Malta", null },
                    { 107, "MH", true, "Marshall Islands", null },
                    { 108, "MQ", true, "Martinique", null },
                    { 109, "MR", true, "Mauritania", null },
                    { 110, "MU", true, "Mauritius", null },
                    { 111, "YT", true, "Mayotte", null },
                    { 112, "MX", true, "Mexico", null },
                    { 113, "FM", true, "Micronesia", null },
                    { 114, "MD", true, "Moldova", null },
                    { 115, "MC", true, "Monaco", null },
                    { 116, "MN", true, "Mongolia", null },
                    { 117, "ME", true, "Montenegro", null },
                    { 118, "MS", true, "Montserrat", null },
                    { 119, "MA", true, "Morocco", null },
                    { 120, "MZ", true, "Mozambique", null },
                    { 121, "MM", true, "Myanmar", null },
                    { 122, "NA", true, "Namibia", null },
                    { 123, "NR", true, "Nauru", null },
                    { 124, "NP", true, "Nepal", null },
                    { 125, "NL", true, "Netherlands", null },
                    { 126, "AN", true, "Netherlands Antilles", null },
                    { 127, "NC", true, "New Caledonia", null },
                    { 128, "NZ", true, "New Zealand", null },
                    { 129, "NI", true, "Nicaragua", null },
                    { 130, "NE", true, "Niger", null },
                    { 131, "NG", true, "Nigeria", null },
                    { 132, "NU", true, "Niue", null },
                    { 133, "NF", true, "Norfolk Island", null },
                    { 134, "KP", true, "North Korea", null },
                    { 135, "MP", true, "Northern Mariana Islands", null },
                    { 136, "PT", true, "Portugal", null },
                    { 137, "PR", true, "Puerto Rico", null },
                    { 138, "QA", true, "Qatar", null },
                    { 139, "GEO", true, "Republic of Georgia", null },
                    { 140, "RE", true, "Reunion", null },
                    { 141, "RO", true, "Romania", null },
                    { 142, "RU", true, "Russia", null },
                    { 143, "RW", true, "Rwanda", null },
                    { 144, "WS", true, "Samoa", null },
                    { 145, "SM", true, "San Marino", null },
                    { 146, "SA", true, "Saudi Arabia", null },
                    { 147, "SN", true, "Senegal", null },
                    { 148, "RS", true, "Serbia", null },
                    { 149, "SC", true, "Seychelles", null },
                    { 150, "SL", true, "Sierra Leone", null },
                    { 151, "SG", true, "Singapore", null },
                    { 152, "SK", true, "Slovakia", null },
                    { 153, "SI", true, "Slovenia", null },
                    { 154, "SB", true, "Solomon Islands", null },
                    { 155, "SO", true, "Somalia", null },
                    { 156, "ZA", true, "South Africa", null },
                    { 157, "GS", true, "South Georgia", null },
                    { 158, "KR", true, "South Korea", null },
                    { 159, "ES", true, "Spain", null },
                    { 160, "LK", true, "Sri Lanka", null },
                    { 161, "SH", true, "St. Helena", null },
                    { 162, "KN", true, "St. Kitts and Nevis", null },
                    { 163, "LC", true, "St. Lucia", null },
                    { 164, "SD", true, "Sudan", null },
                    { 165, "SR", true, "Suriname", null },
                    { 166, "SE", true, "Sweden", null },
                    { 167, "CH", true, "Switzerland", null },
                    { 168, "SY", true, "Syria", null },
                    { 169, "TW", true, "Taiwan", null },
                    { 170, "TJ", true, "Tajikistan", null },
                    { 171, "TZ", true, "Tanzania", null },
                    { 172, "TH", true, "Thailand", null },
                    { 173, "TG", true, "Togo", null },
                    { 174, "TK", true, "Tokelau", null },
                    { 175, "TO", true, "Tonga", null },
                    { 176, "TT", true, "Trinidad and Tobago", null },
                    { 177, "TN", true, "Tunisia", null },
                    { 178, "TR", true, "Turkey", null },
                    { 179, "TM", true, "Turkmenistan", null },
                    { 180, "TV", true, "Tuvalu", null },
                    { 181, "VI", true, "U.S. Virgin Islands", null },
                    { 182, "UG", true, "Uganda", null },
                    { 183, "UA", true, "Ukraine", null },
                    { 184, "UY", true, "Uruguay", null },
                    { 185, "UZ", true, "Uzbekistan", null },
                    { 186, "VU", true, "Vanuatu", null },
                    { 187, "VA", true, "Vatican City", null },
                    { 188, "VE", true, "Venezuela", null },
                    { 189, "VN", true, "Vietnam", null },
                    { 190, "EH", true, "Western Sahara", null },
                    { 191, "YE", true, "Yemen", null },
                    { 192, "YU", true, "Yugoslavia", null },
                    { 193, "ZM", true, "Zambia", null },
                    { 194, "ZW", true, "Zimbabwe", null },
                    { 195, "PH", true, "Philippines", null }
                });

            migrationBuilder.InsertData(
                table: "Degree",
                columns: new[] { "DegreeId", "IsPublished", "Name", "Order" },
                values: new object[,]
                {
                    { 1, true, "পঞ্চম শ্রেনী ", 0 },
                    { 2, true, "অষ্টম শ্রেনী ", 0 },
                    { 3, true, "এস এস সি", 0 },
                    { 4, true, "এ লেভেল", 0 },
                    { 5, true, "ডিপ্লোমা ", 0 },
                    { 6, true, "এইচ এস সি", 0 },
                    { 7, true, "ও লেভেল", 0 },
                    { 8, true, "স্নাতক / অনার্স", 0 },
                    { 9, true, "স্নাতকোত্তর", 0 }
                });

            migrationBuilder.InsertData(
                table: "Designation",
                columns: new[] { "DesignationId", "IsPublished", "Name", "Order" },
                values: new object[,]
                {
                    { 1, true, "সচিব", 1 },
                    { 2, true, "অতিরিক্ত সচিব", 2 },
                    { 3, true, "যুগ্ম সচিব", 3 },
                    { 4, true, "উপসচিব", 4 },
                    { 5, true, "সিস্টেম এনালিস্ট", 5 },
                    { 6, true, "সিনিয়র সহকারি সচিব", 6 },
                    { 7, true, "প্রোগ্রামার", 7 },
                    { 8, true, "সহকারি সচিব", 8 },
                    { 9, true, "সহকারি প্রোগ্রামার", 9 },
                    { 10, true, "হিসাব রক্ষণ কর্মকর্তা", 10 }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "IsPublished", "Name" },
                values: new object[,]
                {
                    { 1, true, "পুরুষ" },
                    { 2, true, "মহিলা" }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "OfficeId", "Address", "ContactEmail", "ContactMobile", "ContactPhone", "IsCurrentOffice", "IsPublished", "LiveUrl", "LogoUrl", "Moto", "Name", "Order", "ParentOfficeId" },
                values: new object[] { 1, "", null, null, null, true, true, "https://www.mofl.gov.bd", "~/images/bd-logo.png", "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", "মৎস্য ও প্রাণিসম্পদ মন্ত্রণালয়", 1, null });

            migrationBuilder.InsertData(
                table: "Section",
                columns: new[] { "SectionId", "IsPublished", "Name", "Order" },
                values: new object[,]
                {
                    { 1, true, "মন্ত্রীর দপ্তর", 1 },
                    { 2, true, "প্রতিমন্ত্রীর দপ্তর", 2 },
                    { 3, true, "সচিবের দপ্তর", 3 },
                    { 4, true, "অতিরিক্ত সচিব (অধিগ্রহণ)", 4 },
                    { 5, true, "অতিরিক্ত সচিব (আইন-১)", 5 },
                    { 6, true, "অতিরিক্ত সচিব (উন্নয়ন)", 6 },
                    { 7, true, "অতিরিক্ত সচিব (জরিপ)", 7 },
                    { 8, true, "অতিরিক্ত সচিব (আইন-২)", 8 },
                    { 9, true, "অতিরিক্ত সচিব (সায়রাত)", 9 },
                    { 10, true, "অতিরিক্ত সচিব (মাঠ প্রশাসন)", 10 },
                    { 11, true, "অতিরিক্ত সচিব (বাজেট ও অডিট)", 11 },
                    { 12, true, "যুগ্মসচিব (প্রশাসন)", 12 },
                    { 13, true, "যুগ্মসচিব (অধিগ্রহণ-১)", 13 },
                    { 14, true, "যুগ্মসচিব (আইন-১)", 14 },
                    { 15, true, "যুগ্মসচিব (সায়রাত)", 15 },
                    { 16, true, "যুগ্মসচিব (জরিপ-২)", 16 },
                    { 17, true, "যুগ্মসচিব (খাসজমি-২)", 17 },
                    { 18, true, "যুগ্মসচিব (কাউন্সিল ও সমন্বয়)", 18 },
                    { 19, true, "উপসচিব (আইন-১)", 19 },
                    { 20, true, "উপসচিব (আইন-২)", 20 },
                    { 21, true, "উপসচিব (আইন-৩)", 21 },
                    { 22, true, "উপসচিব (আইন-৪)", 22 },
                    { 23, true, "উপসচিব (প্রশাসন-১)", 23 },
                    { 24, true, "উপসচিব (প্রশিক্ষণ ও শৃঙ্খল)", 24 },
                    { 25, true, "উপসচিব (প্রশাসন-২)", 25 },
                    { 26, true, "উপসচিব (অধিগ্রহণ-১)", 26 },
                    { 27, true, "উপসচিব (সায়রাত-১)", 27 },
                    { 28, true, "উপসচিব (খসজমি-২)", 28 },
                    { 29, true, "উপপ্রধান", 29 },
                    { 30, true, "সিনিয়র সহকারী সচিব (খাসজমি-১)", 30 },
                    { 31, true, "হিসাব রক্ষণ কর্মকর্তা", 31 },
                    { 32, true, "সিনিয়র সহকারী সচিব (জরিপ-১)", 32 },
                    { 33, true, "আইসিটি", 33 },
                    { 34, true, "প্লানিং-১", 34 },
                    { 35, true, "প্লানিং-২", 35 },
                    { 36, true, "প্লানিং-৩", 36 },
                    { 37, true, "প্লানিং-৪", 37 },
                    { 38, true, "সহকারী সচিব (সায়রাত-২)", 38 },
                    { 39, true, "সহকারী সচিব (অধিগ্রহণ-২)", 39 },
                    { 40, true, "সহকারী সচিব (বাজেট ও অডিট)", 40 }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "OfficeId", "Address", "ContactEmail", "ContactMobile", "ContactPhone", "IsCurrentOffice", "IsPublished", "LiveUrl", "LogoUrl", "Moto", "Name", "Order", "ParentOfficeId" },
                values: new object[,]
                {
                    { 2, "", null, null, null, true, true, "https://www.fisheries.gov.bd", "~/images/bd-logo.png", "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", "মৎস্য অধিদপ্তর", 2, 1 },
                    { 3, "", null, null, null, true, true, "https://www.dls.gov.bd", "~/images/bd-logo.png", "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", "প্রাণিসম্পদ অধিদপ্তর", 3, 1 },
                    { 4, "", null, null, null, true, true, "https://www.fri.gov.bd", "~/images/bd-logo.png", "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", "বাংলাদেশ মৎস্য গবেষণা ইন্সটিটিউট", 4, 1 },
                    { 5, "", null, null, null, true, true, "https://www.blri.gov.bd", "~/images/bd-logo.png", "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", "বাংলাদেশ প্রাণিসম্পদ গবেষণা ইন্সটিটিউট", 5, 1 },
                    { 6, "", null, null, null, true, true, "https://www.bfdc.gov.bd", "~/images/bd-logo.png", "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", "বাংলাদেশ মৎস্য উন্নয়ন কর্পোরেশন", 6, 1 },
                    { 7, "", null, null, null, true, true, "https://www.flid.gov.bd", "~/images/bd-logo.png", "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", "মৎস্য ও প্রাণিসম্পদ তথ্য দপ্তর", 7, 1 },
                    { 8, "", null, null, null, true, true, "https://www.mfa.gov.bd", "~/images/bd-logo.png", "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", "মেরিন ফিশারিজ একাডেমি", 8, 1 },
                    { 9, "", null, null, null, true, true, "https://www.bvc.gov.bd", "~/images/bd-logo.png", "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", "বাংলাদেশ ভেটেরিনারি কাউন্সিল", 9, 1 }
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "StateId", "CountryId", "IsDefault", "IsPublished", "Name", "StateTicker" },
                values: new object[,]
                {
                    { 1, 1, false, true, "বরিশাল", null },
                    { 2, 1, false, true, "চট্টগ্রাম", null },
                    { 3, 1, true, true, "ঢাকা", null },
                    { 4, 1, false, true, "খুলনা", null },
                    { 5, 1, false, true, "রাজশাহী", null },
                    { 6, 1, false, true, "রংপুর", null },
                    { 7, 1, false, true, "সিলেট", null },
                    { 8, 1, false, true, "ময়মনসিংহ", null }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CountryId", "IsPublished", "Name", "StateId" },
                values: new object[,]
                {
                    { 1, 1, true, "বরিশাল", 1 },
                    { 2, 1, true, "বরগুনা", 1 },
                    { 3, 1, true, "ভোলা", 1 },
                    { 4, 1, true, "ঝালকাঠি", 1 },
                    { 5, 1, true, "পটুয়াখালী", 1 },
                    { 6, 1, true, "পিরোজপুর", 1 },
                    { 7, 1, true, "বান্দরবান", 2 },
                    { 8, 1, true, "ব্রাহ্মণবাড়ীয়া", 2 },
                    { 9, 1, true, "চাঁদপুর", 2 },
                    { 10, 1, true, "চট্টগ্রাম", 2 },
                    { 11, 1, true, "কুমিল্লা", 2 },
                    { 12, 1, true, "কক্সবাজার", 2 },
                    { 13, 1, true, "ফেনী", 2 },
                    { 14, 1, true, "খাগড়াছড়ি", 2 },
                    { 15, 1, true, "লক্ষীপুর", 2 },
                    { 16, 1, true, "নোয়াখালী", 2 },
                    { 17, 1, true, "রাঙ্গামাটি", 2 },
                    { 18, 1, true, "ঢাকা", 3 },
                    { 19, 1, true, "ফরিদপুর", 3 },
                    { 20, 1, true, "গাজীপুর", 3 },
                    { 21, 1, true, "গোপালগঞ্জ", 3 },
                    { 22, 1, true, "কিশোরগঞ্জ", 3 },
                    { 23, 1, true, "মাদারীপুর", 3 },
                    { 24, 1, true, "মানিকগঞ্জ", 3 },
                    { 25, 1, true, "মুন্সীগঞ্জ", 3 },
                    { 26, 1, true, "নারায়ণগঞ্জ", 3 },
                    { 27, 1, true, "নরসিংদী", 3 },
                    { 28, 1, true, "রাজবাড়ী", 3 },
                    { 29, 1, true, "শরীয়তপুর", 3 },
                    { 30, 1, true, "টাঙ্গাইল", 3 },
                    { 31, 1, true, "বাগেরহাট", 4 },
                    { 32, 1, true, "চুয়াডাঙ্গা", 4 },
                    { 33, 1, true, "যশোর", 4 },
                    { 34, 1, true, "ঝিনাইদহ", 4 },
                    { 35, 1, true, "খুলনা", 4 },
                    { 36, 1, true, "কুষ্টিয়া", 4 },
                    { 37, 1, true, "মাগুরা", 4 },
                    { 38, 1, true, "মেহেরপুর", 4 },
                    { 39, 1, true, "নড়াইল", 4 },
                    { 40, 1, true, "সাতক্ষিরা", 4 },
                    { 41, 1, true, "জামালপুর", 3 },
                    { 42, 1, true, "ময়মনসিংহ", 3 },
                    { 43, 1, true, "নেত্রকোনা", 3 },
                    { 44, 1, true, "শেরপুর", 3 },
                    { 45, 1, true, "বগুড়া", 5 },
                    { 46, 1, true, "জয়পুরহাট", 5 },
                    { 47, 1, true, "নওগাঁ", 5 },
                    { 48, 1, true, "নাটোর", 5 },
                    { 49, 1, true, "নওয়াবগঞ্জ", 5 },
                    { 50, 1, true, "পাবনা", 5 },
                    { 51, 1, true, "রাজশাহী", 5 },
                    { 52, 1, true, "সিরাজগঞ্জ", 5 },
                    { 53, 1, true, "দিনাজপুর", 6 },
                    { 54, 1, true, "গাইবান্ধা", 6 },
                    { 55, 1, true, "কুড়িগ্রাম", 6 },
                    { 56, 1, true, "লালমনিরহাট", 6 },
                    { 57, 1, true, "নীলফামারী", 6 },
                    { 58, 1, true, "পঞ্চগড়", 6 },
                    { 59, 1, true, "রংপুর", 6 },
                    { 60, 1, true, "ঠাকুরগাঁও", 7 },
                    { 61, 1, true, "হবিগঞ্জ", 7 },
                    { 62, 1, true, "মৌলভীবাজার", 7 },
                    { 63, 1, true, "সুনামগঞ্জ", 7 },
                    { 64, 1, true, "সিলেট", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                table: "City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceRoomBooking_ChairpersonId",
                table: "ConferenceRoomBooking",
                column: "ChairpersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceRoomBooking_EventTypeId",
                table: "ConferenceRoomBooking",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceRoomBooking_OfficeId",
                table: "ConferenceRoomBooking",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Locality_CityId",
                table: "Locality",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Office_ParentOfficeId",
                table: "Office",
                column: "ParentOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                table: "State",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ConferenceRoomBooking");

            migrationBuilder.DropTable(
                name: "Degree");

            migrationBuilder.DropTable(
                name: "Designation");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Locality");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Chairperson");

            migrationBuilder.DropTable(
                name: "EventType");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
