using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ServerDAL.Migrations
{
    public partial class InitdatabasenewPostgres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableDataPeopleInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableDataPeopleInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableDataDoctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Specialty = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    InfoPeopleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableDataDoctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableDataDoctor_TableDataPeopleInfo_InfoPeopleId",
                        column: x => x.InfoPeopleId,
                        principalTable: "TableDataPeopleInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TableDataPatient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InfoPeopleId = table.Column<int>(type: "integer", nullable: true),
                    LikarId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableDataPatient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableDataPatient_TableDataDoctor_LikarId",
                        column: x => x.LikarId,
                        principalTable: "TableDataDoctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TableDataPatient_TableDataPeopleInfo_InfoPeopleId",
                        column: x => x.InfoPeopleId,
                        principalTable: "TableDataPeopleInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TableDataAnalysis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Value = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableDataAnalysis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableDataAnalysis_TableDataPatient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "TableDataPatient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TableDataDisease",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameDesease = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableDataDisease", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableDataDisease_TableDataPatient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "TableDataPatient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TableDataAnalysis_PatientId",
                table: "TableDataAnalysis",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TableDataDisease_PatientId",
                table: "TableDataDisease",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TableDataDoctor_InfoPeopleId",
                table: "TableDataDoctor",
                column: "InfoPeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_TableDataPatient_InfoPeopleId",
                table: "TableDataPatient",
                column: "InfoPeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_TableDataPatient_LikarId",
                table: "TableDataPatient",
                column: "LikarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableDataAnalysis");

            migrationBuilder.DropTable(
                name: "TableDataDisease");

            migrationBuilder.DropTable(
                name: "TableDataPatient");

            migrationBuilder.DropTable(
                name: "TableDataDoctor");

            migrationBuilder.DropTable(
                name: "TableDataPeopleInfo");
        }
    }
}
