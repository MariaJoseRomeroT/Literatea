using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Literatea.Web.Migrations
{
    public partial class room : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookDetails_BookDetailId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Forums_ForumDetails_ForumDetailId",
                table: "Forums");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Forums_ForumId",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropTable(
                name: "ForumDetails");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_ForumId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Forums_ForumDetailId",
                table: "Forums");

            migrationBuilder.DropColumn(
                name: "ForumId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ForumDetailId",
                table: "Forums");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "BookDetailId",
                table: "Books",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_BookDetailId",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.AddColumn<int>(
                name: "ForumId",
                table: "RoomDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookName",
                table: "Books",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Editorial",
                table: "Books",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberPages",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthorName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomDetails_ForumId",
                table: "RoomDetails",
                column: "ForumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDetails_Forums_ForumId",
                table: "RoomDetails",
                column: "ForumId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomDetails_Forums_ForumId",
                table: "RoomDetails");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_RoomDetails_ForumId",
                table: "RoomDetails");

            migrationBuilder.DropColumn(
                name: "ForumId",
                table: "RoomDetails");

            migrationBuilder.DropColumn(
                name: "BookName",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Editorial",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "NumberPages",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Books",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Books",
                newName: "BookDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                newName: "IX_Books_BookDetailId");

            migrationBuilder.AddColumn<int>(
                name: "ForumId",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ForumDetailId",
                table: "Forums",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AutorName = table.Column<string>(nullable: false),
                    BookName = table.Column<string>(nullable: false),
                    Editorial = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ForumId",
                table: "Rooms",
                column: "ForumId");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumDetailId",
                table: "Forums",
                column: "ForumDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookDetails_BookDetailId",
                table: "Books",
                column: "BookDetailId",
                principalTable: "BookDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_ForumDetails_ForumDetailId",
                table: "Forums",
                column: "ForumDetailId",
                principalTable: "ForumDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Forums_ForumId",
                table: "Rooms",
                column: "ForumId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
