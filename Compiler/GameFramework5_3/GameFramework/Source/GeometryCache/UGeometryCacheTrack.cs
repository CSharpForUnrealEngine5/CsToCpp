namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for GeometryCache tracks, stores matrix animation data and implements functionality for it</summary>
[CppInclude("GeometryCacheTrack.h")]
public partial class UGeometryCacheTrack : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The duration of this track&#39;s animation. This is an open ended interval [0..Duration[.</summary>
	public float Duration;
}
