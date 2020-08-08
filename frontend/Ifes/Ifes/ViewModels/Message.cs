using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
   public  class Message
    {

        public Guid Id { get; set; }

        public string UserTo { get; set; }
        public string UserToId { get; set; }

        public string UserFrom { get; set; }
        public string UserFromId { get; set; }

        public string Content { get; set; }

        public DateTime SentDate { get; set; }



        public string Preview() => string.Format("{0} send:  {1}... ", UserFrom, Content.Substring(0, 160));

    }


   
   

}
