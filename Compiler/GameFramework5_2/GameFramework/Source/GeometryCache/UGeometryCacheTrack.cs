#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for GeometryCache tracks, stores matrix animation data and implements functionality for it</summary>
[CppInclude("GeometryCacheTrack.h")]
public partial class UGeometryCacheTrack : UObject {
	///<summary>The duration of this track&#39;s animation. This is an open ended interval [0..Duration[.</summary>
	public float Duration;
}
