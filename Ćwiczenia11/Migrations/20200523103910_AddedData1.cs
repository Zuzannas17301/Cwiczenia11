using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class AddedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "poter123@wp.pl", "Agnieszka", "Poterek" },
                    { 2, "wjaniak99@gmail.com", "Weronika", "Janiak" },
                    { 3, "ah1992@wp.pl", "Anastazja", "Hrevchenko" },
                    { 4, "jk123@wp.pl", "Jarosław", "Kraśko" },
                    { 5, "pkowal34@gmail.com", "Paweł", "Kowalski" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 7, "działanie wzmacniające", "Tran", "doustny" },
                    { 6, "działanie przeciwbólowe", "APAP", "doustny" },
                    { 4, "działanie przeciwgorączowe", "Fervex", "doustny" },
                    { 5, "działanie przeciwzapalne", "WitaminaB12", "domięśniowy" },
                    { 2, "działanie przeciwbólowe", "Paracetamol", "doustny" },
                    { 1, "dzialanie przeciwbolowe", "Ibuprom", "doustny" },
                    { 3, "działanie rozkurczowe", "No-spa", "doustny" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 6, new DateTime(1996, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kamil", "Wardal" },
                    { 1, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Kowalski" },
                    { 2, new DateTime(1997, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Zawadzka" },
                    { 3, new DateTime(1998, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wiktoria", "Piecyk" },
                    { 4, new DateTime(1999, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franciszek", "Lipski" },
                    { 5, new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcin", "Sosenek" },
                    { 7, new DateTime(1998, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milena", "Michnik" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 7);
        }
    }
}
