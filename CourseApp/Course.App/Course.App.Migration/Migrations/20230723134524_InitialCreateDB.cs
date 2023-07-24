using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Course.App.Migrations.Migrations
{
    public partial class InitialCreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubsCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Userid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "3850050, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CCode", "Description", "Name", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "C101", "C# Advanced programming", ".Net Web API", "Active", "C# Net Web API & EF" },
                    { 2, "C102", "ASP.net MVC from scratch", "ASP.net core", "Active", "Build an app with ASPNET MVC" },
                    { 3, "C103", "Angular Fundamental step by step", "Angular 10", "Active", "Angular Fundamental" },
                    { 4, "C104", "PHP for beginner", "PHP for beginner", "Hold", "PHP for beginner" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Gender", "Name", "Status" },
                values: new object[,]
                {
                    { 3850058, "rajan_adiga@terry.test", "female", "Rajan Adiga", "active" },
                    { 3850059, "draupadi_khanna@torphy.test", "male", "Draupadi Khanna", "inactive" },
                    { 3850060, "ganaka_sen_mehrotra@hodkiewicz.example", "male", "Sen. Ganaka Mehrotra", "inactive" },
                    { 3850061, "trivedi_harinarayan@koss.example", "male", "Harinarayan Trivedi", "inactive" },
                    { 3850062, "panicker_rahul_do@emard.example", "female", "Rahul Panicker DO", "active" },
                    { 3850063, "dutta_ujjawal@crooks.example", "male", "Ujjawal Dutta", "inactive" },
                    { 3850064, "sethi_himadri_ii@kihn-gusikowski.test", "male", "Himadri Sethi II", "active" },
                    { 3850065, "vaishno_mrs_pillai@aufderhar.test", "male", "Mrs. Vaishno Pillai", "inactive" },
                    { 3850066, "gandhi_bhavani@hane.test", "female", "Bhavani Gandhi", "inactive" },
                    { 3850068, "leela_embranthiri@feest.example", "female", "Leela Embranthiri", "active" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
