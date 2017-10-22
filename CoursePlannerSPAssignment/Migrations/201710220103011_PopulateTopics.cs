namespace CoursePlannerSPAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTopics : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics (TopicName) VALUES ('Software Development')");
            Sql("INSERT INTO Topics (TopicName) VALUES ('Information Management')");
            Sql("INSERT INTO Topics (TopicName) VALUES ('Technology')");
        }
        
        public override void Down()
        {
        }
    }
}
