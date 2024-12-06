using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CajemesfoodProyect.Migrations
{
    public partial class InitialDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "local",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_local", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "platillos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caducidad = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_platillos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "proveedors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "administradors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administradors", x => x.id);
                    table.ForeignKey(
                        name: "FK_administradors_local_LocalId",
                        column: x => x.LocalId,
                        principalTable: "local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "platillos_Locals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    platilloId = table.Column<int>(type: "int", nullable: false),
                    LocalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_platillos_Locals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_platillos_Locals_local_LocalId",
                        column: x => x.LocalId,
                        principalTable: "local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_platillos_Locals_platillos_platilloId",
                        column: x => x.platilloId,
                        principalTable: "platillos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "localProveedors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    localId = table.Column<int>(type: "int", nullable: false),
                    proveedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_localProveedors", x => x.id);
                    table.ForeignKey(
                        name: "FK_localProveedors_local_localId",
                        column: x => x.localId,
                        principalTable: "local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_localProveedors_proveedors_proveedorId",
                        column: x => x.proveedorId,
                        principalTable: "proveedors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_administradors_LocalId",
                table: "administradors",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_localProveedors_localId",
                table: "localProveedors",
                column: "localId");

            migrationBuilder.CreateIndex(
                name: "IX_localProveedors_proveedorId",
                table: "localProveedors",
                column: "proveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_platillos_Locals_LocalId",
                table: "platillos_Locals",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_platillos_Locals_platilloId",
                table: "platillos_Locals",
                column: "platilloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administradors");

            migrationBuilder.DropTable(
                name: "localProveedors");

            migrationBuilder.DropTable(
                name: "platillos_Locals");

            migrationBuilder.DropTable(
                name: "proveedors");

            migrationBuilder.DropTable(
                name: "local");

            migrationBuilder.DropTable(
                name: "platillos");
        }
    }
}
