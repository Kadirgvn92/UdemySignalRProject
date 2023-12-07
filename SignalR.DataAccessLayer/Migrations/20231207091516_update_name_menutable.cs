using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    public partial class update_name_menutable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_menuTables",
                table: "menuTables");

            migrationBuilder.RenameTable(
                name: "menuTables",
                newName: "MenuTables");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuTables",
                table: "MenuTables",
                column: "MenuTableID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuTables",
                table: "MenuTables");

            migrationBuilder.RenameTable(
                name: "MenuTables",
                newName: "menuTables");

            migrationBuilder.AddPrimaryKey(
                name: "PK_menuTables",
                table: "menuTables",
                column: "MenuTableID");
        }
    }
}
