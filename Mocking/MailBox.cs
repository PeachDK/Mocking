using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mocking
{
    public class MailBox
    {
       private List<Mail> maillist = new List<Mail>();
        public MailBox()
        {
        }

        public int NumReceivedMessages { get { return maillist.Count; } set { } }

        public void Add(Mail o)
        {
            maillist.Add(o);
         
        }

        public string GetLatestMessageText()
        {
            return maillist.Last().Content;
        }
    }
}