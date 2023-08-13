namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Media source for Rivermax streams.</summary>
[CppInclude("RivermaxMediaSource.h")]
public partial class URivermaxMediaSource : UTimeSynchronizableMediaSource {
	public static UClass StaticClass() {return default;}
	///<summary>Player mode to be used.</summary>
	public ERivermaxPlayerMode PlayerMode;
	///<summary>If true, when looking for the sample to render, the current frame number will be looked for.</summary>
	public bool bUseZeroLatency;
	///<summary>If false, use the default source buffer size. If true, a specific resolution will be used.</summary>
	public bool bOverrideResolution;
	///<summary>Incoming stream video resolution</summary>
	public FIntPoint Resolution;
	///<summary>Incoming stream video frame rate</summary>
	public FFrameRate FrameRate;
	///<summary>Incoming stream pixel format</summary>
	public ERivermaxMediaSourcePixelFormat PixelFormat;
	///<summary>Network card interface to use to receive data</summary>
	public string InterfaceAddress;
	///<summary>IP address where incoming stream is coming from</summary>
	public string StreamAddress;
	///<summary>Port used by the sender to send its stream</summary>
	public int Port;
	///<summary>Whether the video input is in sRGB color space.If true, sRGBToLinear will be done on incoming pixels before writing to media texture</summary>
	public bool bIsSRGBInput;
	///<summary>Whether to use GPUDirect if available (Memcopy from NIC to GPU directly bypassing system memory) if available</summary>
	public bool bUseGPUDirect;
}
