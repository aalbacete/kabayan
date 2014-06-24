using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Mail;
using Microsoft.VisualBasic;

namespace Kabayan.Domain.Common
{
    public sealed class MailHelper
    {
       
        public MailHelper()
        {
            
        }

        public bool Sent { get; set; }

        public void SendMailMessage(string @from, string recepient, string bcc, string cc, string subject, string body, List<Attachment> lAttachment = default(List<Attachment>))
        {
            try
            {
                // Instantiate a new instance of MailMessage
                var mMailMessage = new MailMessage();
                int i = 0;
              //  int iCnt = 0;
                
                // Set the sender address of the mail message
                mMailMessage.From = new MailAddress(@from);
                // Set the recepient address of the mail message
                mMailMessage.To.Add(new MailAddress(recepient));

                // Check if the bcc value is nothing or an empty string
                if ((bcc != null) & bcc != string.Empty)
                {
                    // Set the Bcc address of the mail message
                    string[] sBcc = bcc.Split(Convert.ToChar(","));

                    for (i = 0; i <= sBcc.Length - 1; i++)
                    {
                        mMailMessage.Bcc.Add(new MailAddress(address: sBcc[i].ToString(CultureInfo.InvariantCulture)));
                    }

                }

                // Check if the cc value is nothing or an empty value
                if ((cc != null) & cc != string.Empty)
                {
                    string[] sCC = cc.Split(Convert.ToChar(","));

                    for (i = 0; i <= sCC.Length - 1; i++)
                    {
                        // Set the CC address of the mail message
                        mMailMessage.CC.Add(new MailAddress(address: sCC[i].ToString(CultureInfo.InvariantCulture)));
                    }

                }

                if ((lAttachment != null))
                {
                    foreach (Attachment lItem in lAttachment)
                    {
                        mMailMessage.Attachments.Add(lItem);
                    }
                    //iCnt = aryAttachment.Count - 1
                    //For i = 0 To iCnt
                    //    If FileExists(aryAttachment(i)) Then _
                    //      mMailMessage.Attachments.Add(aryAttachment(i))
                    //Next

                }

                // Set the subject of the mail message
                mMailMessage.Subject = subject;
                // Set the body of the mail message
                mMailMessage.Body = body;

                // Set the format of the mail message body as HTML
                mMailMessage.IsBodyHtml = true;
                // Set the priority of the mail message to normal
                mMailMessage.Priority = MailPriority.Normal;

                // Instantiate a new instance of SmtpClient
                var mSmtpClient = new SmtpClient {Timeout = 500000};
                // Send the mail message
                mSmtpClient.Send(mMailMessage);
                this.Sent = true;
            }
            catch 
            {
                this.Sent = false;
                
            }

        }


     

        
    }
}
