using Microsoft.EntityFrameworkCore.Migrations;

namespace Mijalski.GpuStore.Migrations
{
    public partial class GPU_CudaCoresCount_Nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CudaCores",
                table: "AppGraphicsCards");

            migrationBuilder.AddColumn<int>(
                name: "CudaCoresCount",
                table: "AppGraphicsCards",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CudaCoresCount",
                table: "AppGraphicsCards");

            migrationBuilder.AddColumn<int>(
                name: "CudaCores",
                table: "AppGraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
