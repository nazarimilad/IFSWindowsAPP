using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ifes.lib.Migrations
{
    public partial class remove_planeIdFromPassenger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Plane_PlaneId",
                table: "Seat");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlaneId",
                table: "Seat",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Plane_PlaneId",
                table: "Seat",
                column: "PlaneId",
                principalTable: "Plane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Plane_PlaneId",
                table: "Seat");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlaneId",
                table: "Seat",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Plane_PlaneId",
                table: "Seat",
                column: "PlaneId",
                principalTable: "Plane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
