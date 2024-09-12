using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VigilanceFire.Migrations
{
    /// <inheritdoc />
    public partial class Evacuation_Instructions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evacuation_Instructions");

        }
    }
}
