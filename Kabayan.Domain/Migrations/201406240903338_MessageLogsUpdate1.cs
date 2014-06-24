namespace Kabayan.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageLogsUpdate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MessageLog", "Recipient", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MessageLog", "Recipient", c => c.String());
        }
    }
}
