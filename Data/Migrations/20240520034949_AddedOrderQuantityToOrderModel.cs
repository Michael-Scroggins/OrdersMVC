﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticsMVC.Data.Migrations
{
    public partial class AddedOrderQuantityToOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderQuantity",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderQuantity",
                table: "Order");
        }
    }
}