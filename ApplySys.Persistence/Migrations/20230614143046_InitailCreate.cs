using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplySys.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitailCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobType = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applys", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Applys",
                columns: new[] { "Id", "CompanyName", "DateCreated", "JobType", "LastModifiedDate", "Link", "State", "Title" },
                values: new object[] { 2, "Xitaso", new DateTime(2023, 6, 14, 16, 30, 46, 668, DateTimeKind.Local).AddTicks(7699), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hier goes the link ", 0, "Softwareentwickler" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applys");
        }
    }
}
