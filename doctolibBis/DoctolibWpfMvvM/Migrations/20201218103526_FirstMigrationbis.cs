using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctolibWpfMvvM.Migrations
{
    public partial class FirstMigrationbis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SexePatient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodePatient1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Praticiens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEmbauche = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Spécialité = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodePraticien1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Praticiens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Praticiens");
        }
    }
}
