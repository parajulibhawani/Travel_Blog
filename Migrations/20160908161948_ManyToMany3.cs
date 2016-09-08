using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class ManyToMany3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Locations_LocationId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Locations_LocationId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_LocationId",
                table: "People");

            //migrationBuilder.DropColumn(
                //name: "LocationId",
                //table: "People");

            migrationBuilder.CreateTable(
                name: "PersonLocation",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonLocation", x => new { x.PersonId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_PersonLocation_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonLocation_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.AlterColumn<int>(
                //name: "LocationId",
                //table: "Experiences",
                //nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_PersonLocation_LocationId",
                table: "PersonLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonLocation_PersonId",
                table: "PersonLocation",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Locations_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Locations_LocationId",
                table: "Experiences");

            migrationBuilder.DropTable(
                name: "PersonLocation");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "People",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_LocationId",
                table: "People",
                column: "LocationId");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Experiences",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Locations_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Locations_LocationId",
                table: "People",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
