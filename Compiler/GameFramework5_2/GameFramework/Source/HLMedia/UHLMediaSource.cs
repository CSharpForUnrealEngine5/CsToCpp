namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HLMediaSource.h")]
public partial class UHLMediaSource : UBaseMediaSource {
	public static UClass StaticClass() {return default;}
	///<summary>The URL property is an Adaptive Streaming playlist.</summary>
	public bool IsAdaptiveSource;
	///<summary>The URL to the media stream to be played.</summary>
	public string StreamUrl;
}
