using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.CallCenter_Case.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "RepresentativeId",
                table: "CallRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d896929-c13a-4c64-9251-0af6ffd2bdd8", "e60c74d7-d43f-4835-a075-70a29b8bb833", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NameSurname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenEndDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e442832c-0240-4ec8-9a93-5d57c643554e", 0, "292d8ef1-f1fc-4696-9064-35abb935ca42", "admin@example.com", true, false, null, "admin", "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEKDNLOssXoOXEbg9i4ZBL35/MWf53zbIrShO9ZbqAtnF94IBlZO5I2edgq1Zk5xw/Q==", null, false, null, null, "04508e80-ca2c-4054-9728-80697a4f111f", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9d896929-c13a-4c64-9251-0af6ffd2bdd8", "e442832c-0240-4ec8-9a93-5d57c643554e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d896929-c13a-4c64-9251-0af6ffd2bdd8", "e442832c-0240-4ec8-9a93-5d57c643554e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d896929-c13a-4c64-9251-0af6ffd2bdd8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e442832c-0240-4ec8-9a93-5d57c643554e");

            migrationBuilder.AlterColumn<string>(
                name: "RepresentativeId",
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
    }
}
