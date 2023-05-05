using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicacionMVC.Migrations
{
    /// <inheritdoc />
    public partial class CambioTipoDeDatoImageUrlAByteArray : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("UrlImage", "Notices");
            migrationBuilder.AddColumn<byte[]>(
                name: "UrlImage",
                table: "Notices",
                type: "varbinary(max)",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("UrlImage", "Notices");
            migrationBuilder.AlterColumn<string>(
                name: "UrlImage",
                table: "Notices",
                type: "nvarchar(max)",
                nullable: false);
        }
    }
}
