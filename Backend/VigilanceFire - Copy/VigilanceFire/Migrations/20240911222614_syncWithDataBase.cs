using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VigilanceFire.Migrations
{
    /// <inheritdoc />
    public partial class syncWithDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrator"
            );

            migrationBuilder.DropTable(
                name: "Alert");


            migrationBuilder.DropTable(
                name: "User");
        }

    }
}
