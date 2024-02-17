using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootsallTeamManagment.Migrations
{
    [Migration(202402170534)]
    public class _202402170534CreateTeamTable : Migration
    {
        public override void Down()
        {
            Delete.Table("Teams");
        }

        public override void Up()
        {
            Create.Table("Teams")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("PrimaryKitColor").AsInt32().NotNullable()
                .WithColumn("SecondaryKitColor").AsInt32().NotNullable();


        }
    }
}
