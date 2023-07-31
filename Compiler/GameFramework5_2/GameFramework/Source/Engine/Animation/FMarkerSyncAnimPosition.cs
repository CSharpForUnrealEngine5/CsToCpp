#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represent a current play position in an animation</summary>
[CppInclude("Animation/AnimationAsset.h")]
public partial struct FMarkerSyncAnimPosition {
	public string PreviousMarkerName;
	public string NextMarkerName;
	public float PositionBetweenMarkers;
}
