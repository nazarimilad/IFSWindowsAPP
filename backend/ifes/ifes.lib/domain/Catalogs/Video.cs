using ifes.lib.Models.Catalogs.MultiMedia;

namespace ifes.lib.domain.Catalogs {
    public class Video : MultiMedia {
        public int  Rating { get; set; }
        public string  Category { get; set; }
        public Video() {

        }
        public Video(AddVideoModel model) {
            this.Name = model.Name;
            this.Category = model.Category;
            this.Description = model.Description;
            this.Discount = model.Discount;
            this.Duration = model.Duration;
            this.ObjectStorageId = model.ObjectStorageId;
            this.FileExtension = model.FileExtension;
            this.FileSize = model.FileSize;
            this.Rating = model.Rating;
            this.Price = model.Price;
            this.PaymentOption = model.PaymentOption;

        }
    }
}