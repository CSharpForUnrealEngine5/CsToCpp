namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is sent in containing a screen shot run during performance test.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerScreenImage {
	public TArray<byte> ScreenImage;
	public TArray<byte> FrameTrace;
	public string ScreenShotName;
	public FAutomationScreenshotMetadata Metadata;
}
