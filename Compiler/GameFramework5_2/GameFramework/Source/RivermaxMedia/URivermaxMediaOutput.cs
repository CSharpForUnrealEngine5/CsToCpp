#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Output information for a Rivermax media capture.</summary>
[CppInclude("RivermaxMediaOutput.h")]
public partial class URivermaxMediaOutput : UMediaOutput {
	public static UClass StaticClass() {return default;}
	///<summary>Used by frame scheduler to know how to align the output</summary>
	public ERivermaxMediaAlignmentMode AlignmentMode;
	///<summary>Whether to produce a continuous output stream repeating last frame if no new frames provided</summary>
	public bool bDoContinuousOutput;
	///<summary>Experimental flag to use frame counter instead of using NVIDIA Rivermax clock for timestamping output frames</summary>
	public bool bDoFrameCounterTimestamping;
	///<summary>If false, use the default source buffer size. If true, a specific resolution will be used.</summary>
	public bool bOverrideResolution;
	///<summary>Resolution of this output stream</summary>
	public FIntPoint Resolution;
	///<summary>Frame rate of this output stream</summary>
	public FFrameRate FrameRate;
	///<summary>Pixel format for this output stream</summary>
	public ERivermaxMediaOutputPixelFormat PixelFormat;
	///<summary>Network card interface to use to send data</summary>
	public string InterfaceAddress;
	///<summary>Address of the stream. Can be multicast, i.e. 224.1.1.1)</summary>
	public string StreamAddress;
	///<summary>Port to use for this output</summary>
	public int Port;
	///<summary>Whether to use GPUDirect if available (Memcopy from GPU to NIC directly bypassing system) if available</summary>
	public bool bUseGPUDirect;
}
