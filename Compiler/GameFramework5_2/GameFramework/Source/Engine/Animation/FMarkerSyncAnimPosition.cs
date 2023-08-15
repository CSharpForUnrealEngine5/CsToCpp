namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represent a current play position in an animation</summary>
[CppInclude("Animation/AnimationAsset.h")]
public partial struct FMarkerSyncAnimPosition {
	public FName PreviousMarkerName;
	public FName NextMarkerName;
	public float PositionBetweenMarkers;
}
