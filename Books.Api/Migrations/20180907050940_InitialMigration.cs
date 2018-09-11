using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 150, nullable: false),
                    LastName = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 2500, nullable: true),
                    AuthorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("8d7379bb-be72-4acc-8a2f-f04b01fe6339"), "George", "RR Martin" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("eadd5fde-968b-4e5e-b169-15edc4943b4e"), "Stephen", "Fry" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("5b9d3258-a26b-4b65-a3e0-fbb1eeb0be3f"), "Jemes", "Elroy" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("16c75331-90e4-4f55-8446-5bf309242604"), "Douglas", "Adams" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Title" },
                values: new object[] { new Guid("3fb66003-f81d-424a-9105-ea7dbb498478"), new Guid("8d7379bb-be72-4acc-8a2f-f04b01fe6339"), "The book that seems impossible to write.", "The Winds of Winter" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Title" },
                values: new object[] { new Guid("48ac625e-d8e7-4f0a-87dc-8ec1a7f289f8"), new Guid("8d7379bb-be72-4acc-8a2f-f04b01fe6339"), "A Game of Thrones is the first novel in a Songs of Ice and Fire", "A Game of Thrones" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Title" },
                values: new object[] { new Guid("5e77b630-01e8-473c-83b1-d2d7ed7535a2"), new Guid("5b9d3258-a26b-4b65-a3e0-fbb1eeb0be3f"), "The Greek myths are amongst the best stories ever told...", "Mythos" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Title" },
                values: new object[] { new Guid("f136af59-ba99-4864-930a-3d62de9fed94"), new Guid("16c75331-90e4-4f55-8446-5bf309242604"), "In the Hitchhiker's Guide tot he Galaxy...", "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
