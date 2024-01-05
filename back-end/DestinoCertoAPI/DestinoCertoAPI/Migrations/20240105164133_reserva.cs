using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DestinoCertoAPI.Migrations
{
    public partial class reserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Data",
                value: new DateTime(2024, 12, 3, 15, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Data",
                value: new DateTime(2024, 2, 10, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Data",
                value: new DateTime(2024, 5, 5, 10, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Data",
                value: new DateTime(2024, 12, 3, 12, 30, 0, 950, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Data",
                value: new DateTime(2024, 2, 10, 13, 0, 0, 950, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reservas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Data",
                value: new DateTime(2024, 5, 5, 7, 0, 0, 950, DateTimeKind.Local));
        }
    }
}
