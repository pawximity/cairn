namespace cairn.Models
{
    public record PeAnalysisResult(
        string FilePath,
        bool Is64Bit,
        int AddressOfEntryPoint,
        string Machine,
        ulong ImageBase,
        int ImageSize,
        string Format,
        IReadOnlyList<PeSectionResult> SectionResults)
    {
        public string AddressOfEntryPointHex => $"0x{AddressOfEntryPoint:X8}";
    }
}