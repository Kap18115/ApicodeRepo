using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkingwithSQLLiteinAsp.NETCoreWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investors",
                columns: table => new
                {
                    InvestorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvestorName = table.Column<string>(type: "TEXT", nullable: false),
                    InvestorType = table.Column<string>(type: "TEXT", nullable: false),
                    InvestorCountry = table.Column<string>(type: "TEXT", nullable: false),
                    InvestorDateAdded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InvestorLastUpdated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investors", x => x.InvestorId);
                });

            migrationBuilder.CreateTable(
                name: "Commitments",
                columns: table => new
                {
                    CommitmentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvestorId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommitmentAssetClass = table.Column<string>(type: "TEXT", nullable: true),
                    CommitmentAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    CommitmentCurrency = table.Column<string>(type: "TEXT", nullable: true),
                    CommitmentID1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commitments", x => x.CommitmentID);
                    table.ForeignKey(
                        name: "FK_Commitments_Commitments_CommitmentID1",
                        column: x => x.CommitmentID1,
                        principalTable: "Commitments",
                        principalColumn: "CommitmentID");
                    table.ForeignKey(
                        name: "FK_Commitments_Investors_InvestorId",
                        column: x => x.InvestorId,
                        principalTable: "Investors",
                        principalColumn: "InvestorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commitments_CommitmentID1",
                table: "Commitments",
                column: "CommitmentID1");

            migrationBuilder.CreateIndex(
                name: "IX_Commitments_InvestorId",
                table: "Commitments",
                column: "InvestorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commitments");

            migrationBuilder.DropTable(
                name: "Investors");
        }
    }
}
