using cairn.Models;
using System.Collections.Immutable;
using System.Reflection.PortableExecutable;

namespace cairn.Services
{
    public class PeAnalysisService
    {
        public PeAnalysisResult? Analyze(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            PEReader peReader = new PEReader(fileStream);
            PEHeaders peHeaders = peReader.PEHeaders;

            if (peHeaders.PEHeader == null)
            {
                return null;
            }

            // fields from pe header
            PEHeader peHeader = peHeaders.PEHeader;
            bool is64Bit = peHeader.Magic == PEMagic.PE32Plus;
            // fields from sections
            List<PeSectionResult> sectionResults = FindSectionResults(peHeaders.SectionHeaders);
            PeAnalysisResult analysisResult = new(filePath, is64Bit, peHeader.AddressOfEntryPoint, peHeader.ImageBase, peHeader.SizeOfImage, sectionResults);
            return analysisResult;
        }

        private static List<PeSectionResult> FindSectionResults(ImmutableArray<SectionHeader> sectionHeaders)
        {
            List<PeSectionResult> sectionResults = new List<PeSectionResult>();
            foreach (SectionHeader sectionHeader in sectionHeaders)
            {
                PeSectionResult sectionResult = new(sectionHeader.Name, sectionHeader.VirtualAddress, sectionHeader.VirtualAddress, sectionHeader.SizeOfRawData);
                sectionResults.Add(sectionResult);
            }
            return sectionResults;
        }
    }
}