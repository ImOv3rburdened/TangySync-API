using MessagePack;

namespace MareSynchronos.API.Dto.Files
{
    [MessagePackObject(keyAsPropertyName: true)]
    public record ManifestDto
    {
        public string Hash { get; set; } = string.Empty;
        public string Magnet { get; set; } = string.Empty;
        public long Size { get; set; }
        public string[] PieceHashes { get; set; } = System.Array.Empty<string>();
        public string Token { get; set; } = string.Empty;
        public System.DateTime CreatedUtc { get; set; }
    }
}
