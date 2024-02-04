using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryProject.Migrations
{
    public partial class mig234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_messages",
                table: "messages");

            migrationBuilder.RenameTable(
                name: "messages",
                newName: "Messages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "MessagesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "messages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_messages",
                table: "messages",
                column: "MessagesID");
        }
    }
}
