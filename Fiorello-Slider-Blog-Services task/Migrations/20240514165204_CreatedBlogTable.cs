using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorello_Slider_Blog_Services_task.Migrations
{
    public partial class CreatedBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Createdate", "Description", "Image", "SoftDeleted", "Title" },
                values: new object[] { 1, new DateTime(2024, 5, 14, 20, 52, 4, 152, DateTimeKind.Local).AddTicks(9809), "Reshadin blogu", "blog-feature-img-1.jpg", false, "title1" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Createdate", "Description", "Image", "SoftDeleted", "Title" },
                values: new object[] { 2, new DateTime(2024, 5, 14, 20, 52, 4, 152, DateTimeKind.Local).AddTicks(9820), "Ilqarin blogu", "blog-feature-img-3.jpg", false, "title2" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Createdate", "Description", "Image", "SoftDeleted", "Title" },
                values: new object[] { 3, new DateTime(2024, 5, 14, 20, 52, 4, 152, DateTimeKind.Local).AddTicks(9821), "Hacixanin blogu", "blog-feature-img-4.jpg", false, "title3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
