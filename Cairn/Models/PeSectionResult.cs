namespace cairn.Models
{
    public record PeSectionResult(
        string Name,
        int VirtualAddress,
        int VirtualSize,
        int RawSize,
        int RawPointer,
        string Flags)
    {
        public string VirtualAddressHex => $"0x{VirtualAddress:X8}";
        public string RawPointerHex => $"0x{RawPointer:X8}";
    }
}