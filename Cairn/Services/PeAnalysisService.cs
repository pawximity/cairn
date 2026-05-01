using cairn.Models;
using System.Collections.Immutable;
using System.Reflection.PortableExecutable;

namespace cairn.Services
{
    public class PeAnalysisService
    {
        public PeAnalysisResult? Analyze(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            PEReader peReader = new PEReader(fileStream);
            PEHeaders peHeaders = peReader.PEHeaders;
            CoffHeader coffHeader = peHeaders.CoffHeader;

            if (peHeaders.PEHeader == null)
            {
                return null;
            }

            // fields from pe header
            PEHeader peHeader = peHeaders.PEHeader;
            bool is64Bit = peHeader.Magic == PEMagic.PE32Plus;
            string format = peHeader.Magic switch
            {
                PEMagic.PE32 => "PE32 (32-bit)",
                PEMagic.PE32Plus => "PE32+ (64-bit)",
                _ => "Unknown"
            };
            // fields from sections
            List<PeSectionResult> sectionResults = FindSectionResults(peHeaders.SectionHeaders);
            PeAnalysisResult analysisResult = new(
                filePath,
                fileInfo.Length,
                is64Bit,
                peHeader.AddressOfEntryPoint,
                coffHeader.Machine.ToString(),
                peHeader.ImageBase,
                peHeader.SizeOfImage,
                format,
                sectionResults
                );
            return analysisResult;
        }

        private static List<PeSectionResult> FindSectionResults(ImmutableArray<SectionHeader> sectionHeaders)
        {
            List<PeSectionResult> sectionResults = new List<PeSectionResult>();
            foreach (SectionHeader sectionHeader in sectionHeaders)
            {
                PeSectionResult sectionResult = new(
                    sectionHeader.Name,
                    sectionHeader.VirtualAddress,
                    sectionHeader.VirtualAddress,
                    sectionHeader.SizeOfRawData,
                    sectionHeader.PointerToRawData,
                    sectionHeader.SectionCharacteristics.ToString()
                    );
                sectionResults.Add(sectionResult);
            }
            return sectionResults;
        }
    }
}