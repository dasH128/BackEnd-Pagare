using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finanzas.Repository.Migrations
{
    public partial class versionDB000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moneda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Girado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tipoCliente = table.Column<string>(nullable: true),
                    tipoDocumento = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Domicilio = table.Column<string>(nullable: true),
                    DepartamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Girado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Girado_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    DepartamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincia_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeGiradoPersonapartamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GiradoId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    apellidoPaterno = table.Column<string>(nullable: true),
                    apellidoMaterno = table.Column<string>(nullable: true),
                    Dni = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeGiradoPersonapartamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeGiradoPersonapartamento_Girado_GiradoId",
                        column: x => x.GiradoId,
                        principalTable: "Girado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiradoEmpresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GiradoId = table.Column<int>(nullable: false),
                    RazonSocial = table.Column<string>(nullable: true),
                    Ruc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiradoEmpresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiradoEmpresa_Girado_GiradoId",
                        column: x => x.GiradoId,
                        principalTable: "Girado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Distrito",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    ProvinciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distrito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Distrito_Provincia_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Clave = table.Column<string>(nullable: true),
                    RazonSocial = table.Column<string>(nullable: true),
                    Ruc = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    DistritoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Distrito_DistritoId",
                        column: x => x.DistritoId,
                        principalTable: "Distrito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Letra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    valorNominal = table.Column<float>(nullable: false),
                    fechaGiro = table.Column<DateTime>(nullable: false),
                    fechaVencimiento = table.Column<DateTime>(nullable: false),
                    GiradoId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    MonedaId = table.Column<int>(nullable: false),
                    DepartamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Letra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Letra_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Letra_Girado_GiradoId",
                        column: x => x.GiradoId,
                        principalTable: "Girado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Letra_Moneda_MonedaId",
                        column: x => x.MonedaId,
                        principalTable: "Moneda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Letra_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeGiradoPersonapartamento_GiradoId",
                table: "DeGiradoPersonapartamento",
                column: "GiradoId");

            migrationBuilder.CreateIndex(
                name: "IX_Distrito_ProvinciaId",
                table: "Distrito",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Girado_DepartamentoId",
                table: "Girado",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_GiradoEmpresa_GiradoId",
                table: "GiradoEmpresa",
                column: "GiradoId");

            migrationBuilder.CreateIndex(
                name: "IX_Letra_DepartamentoId",
                table: "Letra",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Letra_GiradoId",
                table: "Letra",
                column: "GiradoId");

            migrationBuilder.CreateIndex(
                name: "IX_Letra_MonedaId",
                table: "Letra",
                column: "MonedaId");

            migrationBuilder.CreateIndex(
                name: "IX_Letra_UsuarioId",
                table: "Letra",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_DepartamentoId",
                table: "Provincia",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_DistritoId",
                table: "Usuario",
                column: "DistritoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeGiradoPersonapartamento");

            migrationBuilder.DropTable(
                name: "GiradoEmpresa");

            migrationBuilder.DropTable(
                name: "Letra");

            migrationBuilder.DropTable(
                name: "Girado");

            migrationBuilder.DropTable(
                name: "Moneda");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Distrito");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Departamento");
        }
    }
}
