using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfAppPharmacy.Migrations
{
    /// <inheritdoc />
    public partial class Add_Image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgSource",
                table: "medecines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgSource",
                table: "medecines");
        }
    }
}
