namespace ifes.lib.domain {
    public abstract class MultiMedia : CatalogItem {
        public int FileSize { get; set; }
        public string FileExtension { get; set; }
        public int Duration { get; set; }
        public string ObjectStorageId { get; set; }
    }
}