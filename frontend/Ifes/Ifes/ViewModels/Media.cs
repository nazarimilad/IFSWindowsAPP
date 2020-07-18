using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Media : CatalogItem
    {
        public MediaType MediaType { get; private set; }
        public int Duration { get; private set; }
        public string ObjectStorageId { get; private set; }

        public Media(string id, string name, double price, double discount, PaymentOption paymentOption, MediaType mediaType, int duration, string objectStorageId) : base(id, name, price, discount, paymentOption)
        {
            MediaType = mediaType;
            Duration = duration;
            ObjectStorageId = objectStorageId;
        }
    }
}
