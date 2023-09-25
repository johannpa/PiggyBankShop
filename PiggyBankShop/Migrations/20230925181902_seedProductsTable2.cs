using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PiggyBankShop.Migrations
{
    /// <inheritdoc />
    public partial class seedProductsTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://media.istockphoto.com/id/487095850/fr/photo/petite-fille-posant-pi%C3%A8ce-dans-la-tirelire-cochon.jpg?s=612x612&w=0&k=20&c=UA10ljeAtDh0w4AZdSkfmHVplnWxLKLBa7cq3bUUqMA=");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");
        }
    }
}
