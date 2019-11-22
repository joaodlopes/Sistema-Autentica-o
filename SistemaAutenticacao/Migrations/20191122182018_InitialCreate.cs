using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAutenticacao.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Escola",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Nif = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Abreviatura = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escola", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoUser = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Nif = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    IdEscolaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Curso_Escola_IdEscolaID",
                        column: x => x.IdEscolaID,
                        principalTable: "Escola",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Abreviatura = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CoordenadorIDID = table.Column<int>(nullable: true),
                    SubCoordenadorIDID = table.Column<int>(nullable: true),
                    SecretarioIDID = table.Column<int>(nullable: true),
                    IdEscolaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Departamento_User_CoordenadorIDID",
                        column: x => x.CoordenadorIDID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departamento_Escola_IdEscolaID",
                        column: x => x.IdEscolaID,
                        principalTable: "Escola",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departamento_User_SecretarioIDID",
                        column: x => x.SecretarioIDID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departamento_User_SubCoordenadorIDID",
                        column: x => x.SubCoordenadorIDID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaCientifica",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Abreviatura = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    IdDepartamentoID = table.Column<int>(nullable: true),
                    CoordenadorIDID = table.Column<int>(nullable: true),
                    SubCoordenadorIDID = table.Column<int>(nullable: true),
                    SecretarioIDID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaCientifica", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AreaCientifica_User_CoordenadorIDID",
                        column: x => x.CoordenadorIDID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AreaCientifica_Departamento_IdDepartamentoID",
                        column: x => x.IdDepartamentoID,
                        principalTable: "Departamento",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AreaCientifica_User_SecretarioIDID",
                        column: x => x.SecretarioIDID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AreaCientifica_User_SubCoordenadorIDID",
                        column: x => x.SubCoordenadorIDID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaCientifica_CoordenadorIDID",
                table: "AreaCientifica",
                column: "CoordenadorIDID");

            migrationBuilder.CreateIndex(
                name: "IX_AreaCientifica_IdDepartamentoID",
                table: "AreaCientifica",
                column: "IdDepartamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_AreaCientifica_SecretarioIDID",
                table: "AreaCientifica",
                column: "SecretarioIDID");

            migrationBuilder.CreateIndex(
                name: "IX_AreaCientifica_SubCoordenadorIDID",
                table: "AreaCientifica",
                column: "SubCoordenadorIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_IdEscolaID",
                table: "Curso",
                column: "IdEscolaID");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_CoordenadorIDID",
                table: "Departamento",
                column: "CoordenadorIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_IdEscolaID",
                table: "Departamento",
                column: "IdEscolaID");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_SecretarioIDID",
                table: "Departamento",
                column: "SecretarioIDID");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_SubCoordenadorIDID",
                table: "Departamento",
                column: "SubCoordenadorIDID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaCientifica");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Escola");
        }
    }
}
