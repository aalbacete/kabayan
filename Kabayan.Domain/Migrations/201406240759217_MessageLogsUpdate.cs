namespace Kabayan.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageLogsUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MessageLog", "Sender", c => c.String(maxLength: 25));
            AlterColumn("dbo.MessageLog", "Ip", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MessageLog", "Ip", c => c.String());
            AlterColumn("dbo.MessageLog", "Sender", c => c.String());
        }
    }
}
