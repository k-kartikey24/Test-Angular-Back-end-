using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class Initialcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aa10279-d3e9-41cc-a39e-b7bb3855023f", "AQAAAAIAAYagAAAAEOehnmUZKrixRyYCZEpu6+ZOi7IH6hGmPaahG9/B6Iffk5jf5fXe60YjI/rXDEMm1w==", "87f39cd9-582d-47e4-b4be-775512e96a03" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36133d24-05e9-47a7-92e7-26a3a04657c0", "AQAAAAIAAYagAAAAEFFugz4+/jgC5expBuZd0vaXRKHu8AQ7CVNbM+H1sHeylsaLv2GJzpByC5lk785NFQ==", "17a80c1d-54b0-4a38-836d-07d816449916" });
        }
    }
}
