using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.Models.Catalogs.MultiMedia {
    public abstract class MultiMediaModel : CatalogItemModel {
        public int FileSize { get; set; }
        public string FileExtension { get; set; }
        public int Duration { get; set; }
        public string ObjectStorageId { get; set; }
    }
}
