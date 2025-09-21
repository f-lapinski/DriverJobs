using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriverJobs.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixUserProfileRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserProfileId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "AspNetUsers");
        }
    }
}
