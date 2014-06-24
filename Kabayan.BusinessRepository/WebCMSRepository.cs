using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kabayan.DataAccess;
using Kabayan.Domain.Models;
namespace Kabayan.BusinessRepository
{
    public class WebCmsBusinessRepository
    {
        private WebsiteCmsDataAccess db = new WebsiteCmsDataAccess();

        public WebCmsBusinessRepository()
        {
            
        }
        public List<MessageLog> ContactUsLogs {
            get { return db.MessageLogs; }
        }
    }
}
