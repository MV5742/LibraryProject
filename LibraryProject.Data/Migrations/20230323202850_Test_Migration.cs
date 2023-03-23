using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryProject.Data.Migrations
{
    public partial class Test_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Books",
                newName: "QuantityInStock");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Books",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Authors",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Books",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Books",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortBiography",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AuthorBooks",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBooks", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBooks_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookShops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookShops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookShops_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publishers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksShopBooks",
                columns: table => new
                {
                    BookShopsId = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksShopBooks", x => new { x.BookShopsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_BooksShopBooks_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksShopBooks_BookShops_BookShopsId",
                        column: x => x.BookShopsId,
                        principalTable: "BookShops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Title",
                table: "Books",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBooks_BooksId",
                table: "AuthorBooks",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_BookShops_CityId",
                table: "BookShops",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BookShops_Name",
                table: "BookShops",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BooksShopBooks_BooksId",
                table: "BooksShopBooks",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_CityId",
                table: "Publishers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_Name",
                table: "Publishers",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Users_UserId",
                table: "Books",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Users_UserId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "AuthorBooks");

            migrationBuilder.DropTable(
                name: "BooksShopBooks");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BookShops");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublisherId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Title",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_UserId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "ShortBiography",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "QuantityInStock",
                table: "Books",
                newName: "AuthorId");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Books",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Authors",
                newName: "AuthorId");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
