#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RivermaxMediaSource.h")]
///<summary>Media source for Rivermax streams.</summary>
public partial class URivermaxMediaSource : UTimeSynchronizableMediaSource {
// RivermaxMediaSource
	public ERivermaxPlayerMode PlayerMode;
	public bool bUseZeroLatency;
	public bool bOverrideResolution;
	public FIntPoint Resolution;
	public FFrameRate FrameRate;
	public ERivermaxMediaSourcePixelFormat PixelFormat;
	public string InterfaceAddress;
	public string StreamAddress;
	public int Port;
	public bool bIsSRGBInput;
	public bool bUseGPUDirect;
}
