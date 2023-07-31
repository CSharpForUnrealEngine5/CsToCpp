#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HLMediaSource.h")]
public partial class UHLMediaSource : UBaseMediaSource {
	///<summary>The URL property is an Adaptive Streaming playlist.</summary>
	public bool IsAdaptiveSource;
	///<summary>The URL to the media stream to be played.</summary>
	public string StreamUrl;
}
