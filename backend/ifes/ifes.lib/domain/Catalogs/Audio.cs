using ifes.lib.Models.Catalogs.MultiMedia;

namespace ifes.lib.domain.Catalogs {
    public class Audio : MultiMedia {

        public Audio() {

        }
        public Audio(AddAudioModel model) {
            this.Name = model.Name;
            this.Description = model.Description;
            this.Discount = model.Discount;
            this.Duration = model.Duration;
            this.ObjectStorageId = model.ObjectStorageId;
            this.FileExtension = model.FileExtension;
            this.FileSize = model.FileSize;
            this.Price = model.Price;
            this.PaymentOption = model.PaymentOption;
        }
    }
}