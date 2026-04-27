namespace cairn.Models
{
    public record PeAnalysisResult(
        string FilePath,
        bool Is64Bit,
        int AddressOfEntryPoint,
        ulong ImageBase,
        int ImageSize,
        IReadOnlyList<PeSectionResult> SectionResults
    );
}