using System;

public class PeAnalysisService
{
	public PeAnalysisService()
	{

	}

	public void Analyze(string filePath)
	{
        MessageBox.Show($"Loaded: {filePath}");
    }
}
