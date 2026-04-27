namespace cairn.Models
{
    public record PeAnalysisResult(
        string FilePath,
        bool Is64Bit,
        int AddressOfEntryPoint,
        string Machine,
        ulong ImageBase,
        int ImageSize,
        IReadOnlyList<PeSectionResult> SectionResults
    );
}