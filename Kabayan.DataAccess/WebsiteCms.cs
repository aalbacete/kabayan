using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kabayan.Domain.Context;
using Kabayan.Domain.Models;

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
                using (var kabayanDb = new KabayanContext())
                {
                    var res = (from a in kabayanDb.MessageLogs
                        select a).ToList();

                    return res;
                }
            }
        }
        


    }
}
