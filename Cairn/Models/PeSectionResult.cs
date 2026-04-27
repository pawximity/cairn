namespace cairn.Models
{
    public record PeSectionResult(
        string Name,
        int VirtualAddress,
        int VirtualSize,
        int RawSize
    );
}