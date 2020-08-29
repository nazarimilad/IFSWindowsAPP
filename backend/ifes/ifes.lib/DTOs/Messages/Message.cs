using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.Messages
{
    public class Message
    {


        public Message()
        {

        }


        public Guid Id { get; set; }

        public string UserTo { get; set; }
        public string UserToId { get; set; }

        public string UserFrom { get; set; }
        public string UserFromId { get; set; }

        public string Content { get; set; }

        public DateTime SentDate { get; set; }

    }
}
