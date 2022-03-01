using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    PaymentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nvarchar100 = table.Column<string>(name: "nvarchar(100)", type: "nvarchar(max)", nullable: false),
                    nvarchar16 = table.Column<string>(name: "nvarchar(16)", type: "nvarchar(max)", nullable: false),
                    nvarchar5 = table.Column<string>(name: "nvarchar(5)", type: "nvarchar(max)", nullable: false),
                    nvarchar3 = table.Column<string>(name: "nvarchar(3)", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.PaymentDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentDetails");
        }
    }
}
