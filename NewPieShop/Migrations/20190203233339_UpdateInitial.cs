﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewPieShop.Migrations
{
    public partial class UpdateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Purchase",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Purchase");
        }
    }
}
