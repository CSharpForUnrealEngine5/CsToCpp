namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Derived GeometryCacheTrack class, used for Transform animation.</summary>
[CppInclude("GeometryCacheTrackStreamable.h")]
public partial class UGeometryCacheTrackStreamable : UGeometryCacheTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Codec for this track</summary>
	public UGeometryCacheCodecBase Codec;
	///<summary>StartSampleTime</summary>
	public float StartSampleTime;
}
