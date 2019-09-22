using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace apiLeviathansChilds.infra.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    firstName = table.Column<string>(maxLength: 50, nullable: false),
                    lastName = table.Column<string>(maxLength: 50, nullable: false),
                    nick = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    password = table.Column<string>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "UK_USER_NICK",
                table: "user",
                column: "nick",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_USER_EMAIL",
                table: "user",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
