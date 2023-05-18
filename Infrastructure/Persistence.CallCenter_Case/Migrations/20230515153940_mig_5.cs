using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.CallCenter_Case.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72e11615-5e6c-4f99-99a4-d2243278852d", "896c33b3-dc56-473f-ad26-3d1df1744d5f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72e11615-5e6c-4f99-99a4-d2243278852d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "896c33b3-dc56-473f-ad26-3d1df1744d5f");

            migrationBuilder.RenameColumn(
                name: "TemsilciId",
                table: "CallRecords",
                newName: "RepresentativeId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "824b691c-7ce4-41b5-b31d-fbb626b89910", "9c077c06-eb14-4c57-b5bd-fd6c8f5f1af8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NameSurname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aa2e6473-2eff-4bed-9720-aba33906bb29", 0, "8f2cc073-efaa-4cdc-9d5e-1019281c0fb6", "admin@example.com", true, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEGJlGRIY537+8vnqTNxkDXSKvgQLsTxXuwDECkRLY5MvMZapLh/BQNFViul8Pzvx6w==", null, false, null, null, "2d1a4441-cccd-47b0-a5a7-eb4d61f9c8dc", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "824b691c-7ce4-41b5-b31d-fbb626b89910", "aa2e6473-2eff-4bed-9720-aba33906bb29" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "824b691c-7ce4-41b5-b31d-fbb626b89910", "aa2e6473-2eff-4bed-9720-aba33906bb29" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "824b691c-7ce4-41b5-b31d-fbb626b89910");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa2e6473-2eff-4bed-9720-aba33906bb29");

            migrationBuilder.RenameColumn(
                name: "RepresentativeId",
                table: "CallRecords",
                newName: "TemsilciId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72e11615-5e6c-4f99-99a4-d2243278852d", "23b003d0-f65d-462b-86c3-ef31c4719f60", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NameSurname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "896c33b3-dc56-473f-ad26-3d1df1744d5f", 0, "3fdf238e-07b4-4ee3-b2dd-6d5886c7e8c7", "admin@example.com", true, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEHbglDtHAshG8q08ljZjHQjx1ZvnpWahv9QlUATeiZRFDZ9zk/An1B+2sBqttSI2Pw==", null, false, null, null, "95f1ce3b-6ac8-4860-a3ec-f24b4ab6a091", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "72e11615-5e6c-4f99-99a4-d2243278852d", "896c33b3-dc56-473f-ad26-3d1df1744d5f" });
        }
    }
}
