using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootsallTeamManagment.Migrations
{
    [Migration(202402170856)]
    public class _202402170856CreatePlayerTable : Migration
    {
        public override void Down()
        {
            Delete.Table("Players");
        }

        public override void Up()
        {
            Create.Table("Players")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("BirthDate").AsDateTime().NotNullable();
        }
    }
}
