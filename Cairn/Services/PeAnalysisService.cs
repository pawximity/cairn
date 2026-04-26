using System.Reflection.PortableExecutable;

public class PeAnalysisService
{
	public PeAnalysisService()
	{

	}

	public void Analyze(string filePath)
	{
		FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		PEReader peReader = new PEReader(fileStream);
		if (peReader.PEHeaders.PEHeader is PEHeader peHeader)
		{
            System.Diagnostics.Debug.WriteLine($"Image size, bytes:   {peHeader.SizeOfImage}");
            System.Diagnostics.Debug.WriteLine($"Image base:          0x{peHeader.ImageBase:X}");
            System.Diagnostics.Debug.WriteLine($"File alignment:      0x{peHeader.FileAlignment:X}");
            System.Diagnostics.Debug.WriteLine($"Section alignment:   0x{peHeader.SectionAlignment:X}");
            System.Diagnostics.Debug.WriteLine($"Subsystem:           {peHeader.Subsystem}");
            System.Diagnostics.Debug.WriteLine($"Dll characteristics: {peHeader.DllCharacteristics}");
            System.Diagnostics.Debug.WriteLine($"Linker version:      {peHeader.MajorLinkerVersion}.{peHeader.MinorLinkerVersion}");
            System.Diagnostics.Debug.WriteLine($"OS version:          {peHeader.MajorOperatingSystemVersion}.{peHeader.MinorOperatingSystemVersion}");
        }
    }
}
