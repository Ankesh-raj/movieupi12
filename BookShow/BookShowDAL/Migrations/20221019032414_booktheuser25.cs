using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShowDAL.Migrations
{
    public partial class booktheuser25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImgPoster",
                table: "movies",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPoster",
                table: "movies");
        }
    }
}
