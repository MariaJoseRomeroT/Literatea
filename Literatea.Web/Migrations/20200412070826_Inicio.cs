using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Literatea.Web.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookName = table.Column<string>(nullable: true),
                    AutorName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Editorial = table.Column<string>(nullable: true),
                    NumberPages = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForumDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ForumName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    BookDetailId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BookDetails_BookDetailId",
                        column: x => x.BookDetailId,
                        principalTable: "BookDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ForumDetailId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forums_ForumDetails_ForumDetailId",
                        column: x => x.ForumDetailId,
                        principalTable: "ForumDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: true),
                    ForumId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Forums_ForumId",
                        column: x => x.ForumId,
                        principalTable: "Forums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "readerUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RoomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_readerUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_readerUsers_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookDetailId",
                table: "Books",
                column: "BookDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumDetailId",
                table: "Forums",
                column: "ForumDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_readerUsers_RoomId",
                table: "readerUsers",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BookId",
                table: "Rooms",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ForumId",
                table: "Rooms",
                column: "ForumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "readerUsers");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropTable(
                name: "ForumDetails");
        }
    }
}
