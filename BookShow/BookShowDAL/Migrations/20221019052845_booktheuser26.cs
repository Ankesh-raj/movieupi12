using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShowDAL.Migrations
{
    public partial class booktheuser26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPoster",
                table: "tbluser");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "tbluser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "tbluser",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "tbluser");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "tbluser");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImgPoster",
                table: "tbluser",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
