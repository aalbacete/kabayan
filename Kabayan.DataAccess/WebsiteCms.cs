using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kabayan.Domain.Context;
using Kabayan.Domain.Migrations;
using Kabayan.Domain.Models;
using Kabayan.Domain.Common;
namespace Kabayan.DataAccess
{ 
    public class WebsiteCmsDataAccess
    {
        
        

        public WebsiteCmsDataAccess()
        {
           
            
        }

        public List<MessageLog> MessageLogs {
            get
            {
                try
                {
                    using (var kabayanDb = new KabayanContext())
                    {
                        var res = (from a in kabayanDb.MessageLogs
                                   select a).ToList();

                        return res;
                    }
                }
                catch(Exception ex)
                {

                    if (KabayanCollection.DebugMode)
                    {
                        //var l = new SystemLogs{ ApplicationName = "Test"} ;
                    }  else throw new Exception(ex.Message);                         
                }
               return null;
            }
        }
        


    }
}
