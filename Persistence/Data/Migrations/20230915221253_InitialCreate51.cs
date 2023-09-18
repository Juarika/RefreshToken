using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate51 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_categoria_CategoriaId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_marca_MarcaId",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "productos");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_MarcaId",
                table: "productos",
                newName: "IX_productos_MarcaId");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_CategoriaId",
                table: "productos",
                newName: "IX_productos_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productos",
                table: "productos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productos_categoria_CategoriaId",
                table: "productos",
                column: "CategoriaId",
                principalTable: "categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productos_marca_MarcaId",
                table: "productos",
                column: "MarcaId",
                principalTable: "marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productos_categoria_CategoriaId",
                table: "productos");

            migrationBuilder.DropForeignKey(
                name: "FK_productos_marca_MarcaId",
                table: "productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productos",
                table: "productos");

            migrationBuilder.RenameTable(
                name: "productos",
                newName: "Producto");

            migrationBuilder.RenameIndex(
                name: "IX_productos_MarcaId",
                table: "Producto",
                newName: "IX_Producto_MarcaId");

            migrationBuilder.RenameIndex(
                name: "IX_productos_CategoriaId",
                table: "Producto",
                newName: "IX_Producto_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_categoria_CategoriaId",
                table: "Producto",
                column: "CategoriaId",
                principalTable: "categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_marca_MarcaId",
                table: "Producto",
                column: "MarcaId",
                principalTable: "marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
