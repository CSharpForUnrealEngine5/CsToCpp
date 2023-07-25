#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message that is sent in containing a screen shot run during performance test.</summary>
public partial struct FAutomationWorkerScreenImage {
// AutomationWorkerScreenImage
	public TArray<byte> ScreenImage;
	public TArray<byte> FrameTrace;
	public string ScreenShotName;
	public FAutomationScreenshotMetadata Metadata;
}
