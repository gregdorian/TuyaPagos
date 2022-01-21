using Microsoft.EntityFrameworkCore.Migrations;

namespace co.Tuya.Infrastructure.Data.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logisticas",
                columns: table => new
                {
                    LogisticaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdenCompraId = table.Column<int>(type: "int", nullable: false),
                    NombreCompañia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logisticas", x => x.LogisticaId);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesCompras",
                columns: table => new
                {
                    OrdenCompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LogisticaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesCompras", x => x.OrdenCompraId);
                    table.ForeignKey(
                        name: "FK_OrdenesCompras_Logisticas_LogisticaId",
                        column: x => x.LogisticaId,
                        principalTable: "Logisticas",
                        principalColumn: "LogisticaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    clienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrdenCompraId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.clienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_OrdenesCompras_OrdenCompraId",
                        column: x => x.OrdenCompraId,
                        principalTable: "OrdenesCompras",
                        principalColumn: "OrdenCompraId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    produtoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrdenCompraId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.produtoId);
                    table.ForeignKey(
                        name: "FK_Productos_OrdenesCompras_OrdenCompraId",
                        column: x => x.OrdenCompraId,
                        principalTable: "OrdenesCompras",
                        principalColumn: "OrdenCompraId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "clienteId", "Apellidos", "Ciudad", "Direccion", "FullName", "Nombres", "OrdenCompraId", "Telefono" },
                values: new object[,]
                {
                    { 1, "Muñoz", "Barbosa", "cra 35 #100-00", "Muñoz, Carlos", "Carlos", null, "34654612" },
                    { 2, "Lara", "Itagui", " clle 54 #40-00", "Lara, Andres", "Andres", null, "4657712" },
                    { 3, "Lopez", "Envigado", " cra 34 #50-00", "Lopez, Pablo", "Pablo", null, "35488820" },
                    { 4, "Ruiz", "Medellin", " cra 25 #84-00", "Ruiz, Ana", "Ana", null, "65444777" }
                });

            migrationBuilder.InsertData(
                table: "Logisticas",
                columns: new[] { "LogisticaId", "Direccion", "NombreCompañia", "OrdenCompraId", "Telefono" },
                values: new object[,]
                {
                    { 1, "cra 50 #100-00", "Carlos", 0, "46134652" },
                    { 2, " clle 4 #40-00", "Andres", 0, "5746712" },
                    { 3, " cra 45 #50-00", "Pablo", 0, "35884820" },
                    { 4, " cra 25 #84-00", "Ana", 0, "44765477" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "produtoId", "Descripcion", "OrdenCompraId", "Precio" },
                values: new object[,]
                {
                    { 1, "Mouse", null, 3500m },
                    { 2, "Teclado", null, 50500m },
                    { 3, "Pantalla", null, 605000m },
                    { 4, "Tablet", null, 32500m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_OrdenCompraId",
                table: "Clientes",
                column: "OrdenCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesCompras_LogisticaId",
                table: "OrdenesCompras",
                column: "LogisticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_OrdenCompraId",
                table: "Productos",
                column: "OrdenCompraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "OrdenesCompras");

            migrationBuilder.DropTable(
                name: "Logisticas");
        }
    }
}
