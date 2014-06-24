/* --------------
 * By Allan
 * 06/24/2014
 * --------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kabayan.Domain;
namespace Kabayan.Domain.Models
{
    public partial class MessageLog
    {
        public int Id { get; set; }

        
        public string Message { get; set; }

        [StringLength(25)]
        public string Recipient { get; set; }

        [StringLength(25, ErrorMessage = "*", MinimumLength = 12)]
        public string Sender { get; set; }
        public DateTime? MessageSentTime { get; set; }

        [StringLength(25, ErrorMessage = "Invalid Work Phone Number", MinimumLength = 12)]
        public string Ip { get; set; }

    }
    
}
