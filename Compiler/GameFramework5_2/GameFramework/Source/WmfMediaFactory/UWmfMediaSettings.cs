#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the WmfMedia plug-in.</summary>
[CppInclude("WmfMediaSettings.h")]
public partial class UWmfMediaSettings : UObject {
	///<summary>Whether to allow the loading of media that uses non-standard codecs (default = off).</summary>
	public bool AllowNonStandardCodecs;
	///<summary>Enable low latency processing in the Windows media pipeline (default = off).</summary>
	public bool LowLatency;
	///<summary>Play audio tracks via the operating system&#39;s native sound mixer (default = off).</summary>
	public bool NativeAudioOut;
	///<summary>Use hardware accelerated video acceleration (GPU) when possible otherwise fallback to software implementation (CPU), Windows and DX11 only.</summary>
	public bool HardwareAcceleratedVideoDecoding;
}
