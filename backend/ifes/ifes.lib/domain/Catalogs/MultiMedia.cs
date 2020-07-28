namespace ifes.lib.domain.Catalogs {
    public abstract class MultiMedia : CatalogItem {
        public int FileSize { get; set; }
        public string FileExtension { get; set; }
        public int Duration { get; set; }
        public string ObjectStorageId { get; set; }
    }
}