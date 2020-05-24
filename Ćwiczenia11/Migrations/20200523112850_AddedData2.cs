using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class AddedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 23, 13, 28, 49, 702, DateTimeKind.Local).AddTicks(7048), new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 2, new DateTime(2020, 5, 23, 13, 28, 49, 705, DateTimeKind.Local).AddTicks(7265), new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 3, new DateTime(2020, 5, 23, 13, 28, 49, 705, DateTimeKind.Local).AddTicks(7367), new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 },
                    { 4, new DateTime(2020, 5, 23, 13, 28, 49, 705, DateTimeKind.Local).AddTicks(7380), new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 5, new DateTime(2020, 5, 23, 13, 28, 49, 705, DateTimeKind.Local).AddTicks(7388), new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7 },
                    { 6, new DateTime(2020, 5, 23, 13, 28, 49, 705, DateTimeKind.Local).AddTicks(7395), new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 7, new DateTime(2020, 5, 23, 13, 28, 49, 705, DateTimeKind.Local).AddTicks(7402), new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 8, new DateTime(2020, 5, 23, 13, 28, 49, 705, DateTimeKind.Local).AddTicks(7410), new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "PrescriptionMedicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "rano i wieczorem", 2 },
                    { 2, 2, "raz dziennie przed snem", 1 },
                    { 3, 3, "raz dziennie", 1 },
                    { 4, 4, "3 razy dziennie", 3 },
                    { 5, 5, "Po posilku", 2 },
                    { 6, 6, "raz dziennie", 1 },
                    { 7, 7, "raz dziennie przez miesiac", 1 },
                    { 1, 8, "rano i wieczorem", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 8);
        }
    }
}
