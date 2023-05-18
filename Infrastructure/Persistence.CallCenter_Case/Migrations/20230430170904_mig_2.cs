using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.CallCenter_Case.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a718a85-a658-4265-9315-9a8be672eedd", "1dc673a8-f7b3-4d15-bda2-6b1d82e8305c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a718a85-a658-4265-9315-9a8be672eedd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dc673a8-f7b3-4d15-bda2-6b1d82e8305c");

            migrationBuilder.AddColumn<string>(
                name: "Reply",
                table: "CallRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Reply",
                table: "CallRecords");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a718a85-a658-4265-9315-9a8be672eedd", "fb789c3e-4367-469e-ac57-eeada93047e3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NameSurname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1dc673a8-f7b3-4d15-bda2-6b1d82e8305c", 0, "22ec39c9-0591-442b-8ec0-879f31aec784", "admin@example.com", true, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEIAD7XYwtifQK/HCLlGnJMhfHFND+FPy9kinLlclUj44cqFJqB69/enUsNOv0AnxAA==", null, false, null, null, "b53afaf7-f8b2-46b1-8212-99d3ecec77e9", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a718a85-a658-4265-9315-9a8be672eedd", "1dc673a8-f7b3-4d15-bda2-6b1d82e8305c" });
        }
    }
}
