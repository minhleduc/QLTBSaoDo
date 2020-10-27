using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTBSaoDo.Data.Migrations
{
    public partial class themNgayThanhLyVaLapDat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NgayThanhLy",
                table: "TSThanhLy",
                type: "Date",
                nullable: true,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayLapDat",
                table: "ThietBiPhong",
                type: "Date",
                nullable: true,
                defaultValueSql: "GetDate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayThanhLy",
                table: "TSThanhLy");

            migrationBuilder.DropColumn(
                name: "NgayLapDat",
                table: "ThietBiPhong");
        }
    }
}
