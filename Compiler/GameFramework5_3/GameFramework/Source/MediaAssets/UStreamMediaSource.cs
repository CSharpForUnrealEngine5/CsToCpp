namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StreamMediaSource.h")]
public partial class UStreamMediaSource : UBaseMediaSource {
	public static UClass StaticClass() {return default;}
	///<summary>The URL to the media stream to be played.</summary>
	public string StreamUrl;
}
