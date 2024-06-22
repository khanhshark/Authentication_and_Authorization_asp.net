using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab7.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "240a6ec2-b12c-4844-a812-ec6883c13d8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "518663d1-0d55-4c5b-9349-103a6d7558f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91936296-3523-4c38-8c71-1036f03b915f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc3d687b-b01f-4354-9924-319a169cd180");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26a5f3c7-bb17-4027-b244-345782faf8aa", "1", "Admin", "Admin" },
                    { "3eccbd0a-5c26-4896-be2b-50d53ac2f2f7", "2", "User", "User" },
                    { "bfe3d5e6-642a-4cd4-b9e8-7d1cf0a10c76", "3", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26a5f3c7-bb17-4027-b244-345782faf8aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3eccbd0a-5c26-4896-be2b-50d53ac2f2f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfe3d5e6-642a-4cd4-b9e8-7d1cf0a10c76");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "240a6ec2-b12c-4844-a812-ec6883c13d8d", "1", "Admin", "Admin" },
                    { "518663d1-0d55-4c5b-9349-103a6d7558f5", "3", "HR", "HR" },
                    { "91936296-3523-4c38-8c71-1036f03b915f", "2", "User", "User" },
                    { "bc3d687b-b01f-4354-9924-319a169cd180", "4", "HR1", "HR1" }
                });
        }
    }
}
