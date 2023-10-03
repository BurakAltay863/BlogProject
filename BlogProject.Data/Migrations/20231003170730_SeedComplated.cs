using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedComplated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreteDate", "CretedBy", "DeleteBy", "DeleteDate", "IsDeleted", "ModifieDate", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("c6af89f7-5a41-43a1-b89d-4599c12fb1da"), new DateTime(2023, 10, 3, 20, 7, 29, 990, DateTimeKind.Local).AddTicks(4528), "Admin Test", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Visual Studio 2022" },
                    { new Guid("e215c0a4-1a05-46cf-80df-5509e5c5c6af"), new DateTime(2023, 10, 3, 20, 7, 29, 990, DateTimeKind.Local).AddTicks(4515), "Admin Test", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "aSP.nETcORE" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreteDate", "CretedBy", "DeleteBy", "DeleteDate", "FileName", "FileType", "IsDeleted", "ModifieDate", "ModifiedBy" },
                values: new object[,]
                {
                    { new Guid("84c46e0f-5e3e-461d-b26a-f58342ac8aa2"), new DateTime(2023, 10, 3, 20, 7, 29, 990, DateTimeKind.Local).AddTicks(4630), "Admin Test", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/testimage", "jpg", false, null, null },
                    { new Guid("92514e8b-b516-4aeb-bbcb-d1fe6e690542"), new DateTime(2023, 10, 3, 20, 7, 29, 990, DateTimeKind.Local).AddTicks(4632), "Admin Test", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/vstest", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreteDate", "CretedBy", "DeleteBy", "DeleteDate", "ImageId", "IsDeleted", "ModifieDate", "ModifiedBy", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2bfb435b-fa74-4b36-9fd1-d6ecc84afb52"), new Guid("c6af89f7-5a41-43a1-b89d-4599c12fb1da"), " Visual Studio Deb-neme Makelsi  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum", new DateTime(2023, 10, 3, 20, 7, 29, 990, DateTimeKind.Local).AddTicks(4342), "Admin test", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("92514e8b-b516-4aeb-bbcb-d1fe6e690542"), false, null, null, "Visual Studio Deb-neme Makelsi ", 15 },
                    { new Guid("9729ba3c-9d6b-4b74-ad7a-4b3a39461036"), new Guid("e215c0a4-1a05-46cf-80df-5509e5c5c6af"), " Asp.net core projesi Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum", new DateTime(2023, 10, 3, 20, 7, 29, 990, DateTimeKind.Local).AddTicks(4337), "Admin test", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("84c46e0f-5e3e-461d-b26a-f58342ac8aa2"), false, null, null, "Asp.net core projesi ", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2bfb435b-fa74-4b36-9fd1-d6ecc84afb52"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9729ba3c-9d6b-4b74-ad7a-4b3a39461036"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6af89f7-5a41-43a1-b89d-4599c12fb1da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e215c0a4-1a05-46cf-80df-5509e5c5c6af"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("84c46e0f-5e3e-461d-b26a-f58342ac8aa2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("92514e8b-b516-4aeb-bbcb-d1fe6e690542"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
