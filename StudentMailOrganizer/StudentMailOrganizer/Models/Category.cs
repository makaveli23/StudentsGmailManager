﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMailOrganizer.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<MailMessage> Mails { get; set; }
        public List<Sender> AcceptedEmails { get; set; }
        public Category()
        {
            Mails = new List<MailMessage>();
            AcceptedEmails = new List<Sender>();
        }
    }
}
