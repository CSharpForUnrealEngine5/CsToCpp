#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RivermaxMediaOutput.h")]
///<summary>Output information for a Rivermax media capture.</summary>
public partial class URivermaxMediaOutput : UMediaOutput {
// RivermaxMediaOutput
	public ERivermaxMediaAlignmentMode AlignmentMode;
	public bool bDoContinuousOutput;
	public bool bDoFrameCounterTimestamping;
	public bool bOverrideResolution;
	public FIntPoint Resolution;
	public FFrameRate FrameRate;
	public ERivermaxMediaOutputPixelFormat PixelFormat;
	public string InterfaceAddress;
	public string StreamAddress;
	public int Port;
	public bool bUseGPUDirect;
}
