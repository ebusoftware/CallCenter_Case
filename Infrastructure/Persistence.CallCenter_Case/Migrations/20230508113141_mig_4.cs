using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.CallCenter_Case.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f854f03c-0451-41b6-9941-fb1b1fd242e2", "e1526910-1ef8-4c2e-9b78-1962fc691be1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f854f03c-0451-41b6-9941-fb1b1fd242e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1526910-1ef8-4c2e-9b78-1962fc691be1");

            migrationBuilder.AddColumn<string>(
                name: "TemsilciId",
                table: "CallRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TemsilciId",
                table: "CallRecords");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f854f03c-0451-41b6-9941-fb1b1fd242e2", "14288a57-7246-4ebb-be4c-909f34df5c24", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NameSurname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e1526910-1ef8-4c2e-9b78-1962fc691be1", 0, "5324899c-24de-4db6-957b-0c67fd17cfe9", "admin@example.com", true, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEOc6F+ZKPM74gzqbxJhC4JBlxKj/F+I3vdYRiPF9+rFXUP7WcZWEQfHRDmk3arjM4Q==", null, false, null, null, "5722f1af-63c9-4035-8a4f-d5e955476fb3", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f854f03c-0451-41b6-9941-fb1b1fd242e2", "e1526910-1ef8-4c2e-9b78-1962fc691be1" });
        }
    }
}
