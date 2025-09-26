namespace MareSynchronosAPI.Data
{
    public class ManifestDto
    {
        public string Id { get; set; }            // unique file id
        public string Magnet { get; set; }        // magnet:?xt=urn:btih...
        public long Size { get; set; }            // size in bytes
        public string[] PieceHashes { get; set; } // per-chunk SHA256
        public string Token { get; set; }         // server auth token
        public DateTime CreatedUtc { get; set; }
    }
}