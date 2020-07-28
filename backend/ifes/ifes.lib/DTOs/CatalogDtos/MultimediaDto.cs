using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.CatalogDtos {
    public  abstract class MultimediaDto : CatalogItemDto {
        public int FileSize { get; set; }
        public string FileExtension { get; set; }
        public int Duration { get; set; }
        public string ObjectStorageId { get; set; }
    }
}
