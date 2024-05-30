using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdersMVC.Data.Migrations
{
    public partial class AddedOrderNameToOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderName",
                table: "Order");
        }
    }
}
