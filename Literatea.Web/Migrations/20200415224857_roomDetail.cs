using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Literatea.Web.Migrations
{
    public partial class roomDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReaderUsers_Rooms_RoomId",
                table: "ReaderUsers");

            migrationBuilder.DropIndex(
                name: "IX_ReaderUsers_RoomId",
                table: "ReaderUsers");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "ReaderUsers");

            migrationBuilder.CreateTable(
                name: "RoomDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdmissionDate = table.Column<DateTime>(nullable: false),
                    ReaderUserId = table.Column<int>(nullable: true),
                    RoomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomDetails_ReaderUsers_ReaderUserId",
                        column: x => x.ReaderUserId,
                        principalTable: "ReaderUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomDetails_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomDetails_ReaderUserId",
                table: "RoomDetails",
                column: "ReaderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDetails_RoomId",
                table: "RoomDetails",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomDetails");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "ReaderUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReaderUsers_RoomId",
                table: "ReaderUsers",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderUsers_Rooms_RoomId",
                table: "ReaderUsers",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
