using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalManagementSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Contact = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    patientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    gender = table.Column<string>(maxLength: 1, nullable: false),
                    contact = table.Column<string>(maxLength: 15, nullable: false),
                    address = table.Column<string>(nullable: false),
                    medicalHistory = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.patientID);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Appointment_PatientID = table.Column<int>(nullable: false),
                    Appointment_Doctor = table.Column<int>(nullable: false),
                    AppointMentDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_Appointment_Doctor",
                        column: x => x.Appointment_Doctor,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_Appointment_PatientID",
                        column: x => x.Appointment_PatientID,
                        principalTable: "Patients",
                        principalColumn: "patientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bills_PatientID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillID);
                    table.ForeignKey(
                        name: "FK_Bills_Patients_Bills_PatientID",
                        column: x => x.Bills_PatientID,
                        principalTable: "Patients",
                        principalColumn: "patientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    RecordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Records_Patient = table.Column<int>(nullable: false),
                    DoctorID = table.Column<int>(nullable: false),
                    Diagnosis = table.Column<string>(nullable: false),
                    Treatment = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.RecordID);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Patients_Records_Patient",
                        column: x => x.Records_Patient,
                        principalTable: "Patients",
                        principalColumn: "patientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Appointment_Doctor",
                table: "Appointments",
                column: "Appointment_Doctor");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Appointment_PatientID",
                table: "Appointments",
                column: "Appointment_PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_Bills_PatientID",
                table: "Bills",
                column: "Bills_PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_DoctorID",
                table: "MedicalRecords",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_Records_Patient",
                table: "MedicalRecords",
                column: "Records_Patient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
