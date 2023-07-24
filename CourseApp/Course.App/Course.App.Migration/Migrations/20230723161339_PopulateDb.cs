using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Course.App.Migrations.Migrations
{
    public partial class PopulateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var path = Path.Combine("SqlScripts", "", "TrainingDBScripts.sql");
            var sqlStatement = File.ReadAllText(path);
            migrationBuilder.Sql(sqlStatement);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
