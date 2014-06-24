using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Kabayan.Domain;
using Kabayan.Domain.Models;

namespace Kabayan.Domain.Context
{
    public  class KabayanContext: DbContext
    {

        public KabayanContext() : 
            base("name=KabayanEntities")
        {
            try
            {

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public DbSet<MessageLog> MessageLogs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    public class KabayanInitializer : DropCreateDatabaseIfModelChanges<KabayanContext>
    {
        protected override void Seed(KabayanContext context)
        {
            var messagelogs = new List<MessageLog>
            {
                new MessageLog
                {
                    Message = "Test",
                    Ip = "112.1.1.1",
                    MessageSentTime = DateTime.Today,
                    Recipient = "aalbacete@aaa.com",
                    Sender = "sender@test.com"
                },
                  new MessageLog
                {
                    Message = "Test 2",
                    Ip = "112.1.1.1",
                    MessageSentTime = DateTime.Today,
                    Recipient = "aalbacete@aaa.com",
                    Sender = "sender@test.com"
                }
            };

            messagelogs.ForEach(s=>context.MessageLogs.Add(s));
            context.SaveChanges();
        }
    }
}