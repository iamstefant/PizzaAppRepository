using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEDC.PizzaApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PizzaOrder",
                columns: new[] { "Id", "NumberOfPizzas", "OrderId", "PizzaId", "PizzaSize", "Price" },
                values: new object[] { 4, 2, 2, 3, 2, 400.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PizzaOrder",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
