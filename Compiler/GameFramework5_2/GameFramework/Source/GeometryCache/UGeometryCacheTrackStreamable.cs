#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Derived GeometryCacheTrack class, used for Transform animation.</summary>
[CppInclude("GeometryCacheTrackStreamable.h")]
public partial class UGeometryCacheTrackStreamable : UGeometryCacheTrack {
	///<summary>Codec for this track</summary>
	public UGeometryCacheCodecBase Codec;
	///<summary>StartSampleTime</summary>
	public float StartSampleTime;
}
