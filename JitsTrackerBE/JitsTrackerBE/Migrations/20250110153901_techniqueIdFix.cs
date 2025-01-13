using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JitsTrackerBE.Migrations
{
    /// <inheritdoc />
    public partial class techniqueIdFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropForeignKey(
                name: "FK_Moves_Techniques_TechniqueIdId",
                table: "Moves");
            
            migrationBuilder.DropIndex(
                name: "IX_Moves_TechniqueIdId", // Name of the existing index
                table: "Moves");
            
            migrationBuilder.RenameColumn(
                name: "TechniqueIdId",       // Current column name
                table: "Moves",          // Table containing the column
                newName: "TechniqueId"); 
            
            migrationBuilder.AddForeignKey(
                name: "FK_Moves_Techniques_TechniqueId",
                table: "Moves",
                column: "TechniqueId",
                principalTable: "Techniques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            
            migrationBuilder.CreateIndex(
                name: "FK_Moves_Techniques_TechniqueId", // Name of the new index
                table: "Moves",
                column: "TechniqueId",
                unique: false); // Optional: Make it unique
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moves_Techniques_TechniqueId",
                table: "Moves");
            
            migrationBuilder.RenameColumn(
                name: "TechniqueId",       // Current column name
                table: "Moves",          // Table containing the column
                newName: "TechniqueIdId"); 
            
            migrationBuilder.AddForeignKey(
                name: "FK_Moves_Techniques_TechniqueIdId",
                table: "Moves",
                column: "TechniqueIdId",
                principalTable: "Techniques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
        }
    }

