using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.CallCenter_Case.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "730a6396-b4e3-47f8-9e18-bd521e1c2b75", "69a82844-cb49-4ad5-88f3-23d06d6ad625" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "730a6396-b4e3-47f8-9e18-bd521e1c2b75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69a82844-cb49-4ad5-88f3-23d06d6ad625");

            migrationBuilder.AlterColumn<string>(
                name: "Reply",
                table: "CallRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Reply",
                table: "CallRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "730a6396-b4e3-47f8-9e18-bd521e1c2b75", "b82122ba-e319-42cb-90b8-31b40012606f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NameSurname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "69a82844-cb49-4ad5-88f3-23d06d6ad625", 0, "0a53f97b-16ce-4f5e-8b75-861e123e0038", "admin@example.com", true, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEDJb5pHnoRk+bk/TjAQnfYF4L1vEk7UVKE7fRhjYXzPctOuc1pEIEOjqYf9L/UWtAw==", null, false, null, null, "4aec9846-050d-4473-b505-6b70522f74fc", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "730a6396-b4e3-47f8-9e18-bd521e1c2b75", "69a82844-cb49-4ad5-88f3-23d06d6ad625" });
        }
    }
}
