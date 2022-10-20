using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShowDAL.Migrations
{
    public partial class bookyheusrr24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImgPoster",
                table: "tbluser",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPoster",
                table: "tbluser");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
