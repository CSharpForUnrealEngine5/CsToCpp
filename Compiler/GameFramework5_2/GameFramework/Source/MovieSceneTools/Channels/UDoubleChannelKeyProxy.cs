namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/DoubleChannelKeyProxy.h")]
public partial class UDoubleChannelKeyProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>User-facing time of the key, applied to the actual key on PostEditChange, and updated every tick</summary>
	public FFrameNumber Time;
	///<summary>User-facing value of the key, applied to the actual key on PostEditChange, and updated every tick</summary>
	public FMovieSceneDoubleValue Value;
}
