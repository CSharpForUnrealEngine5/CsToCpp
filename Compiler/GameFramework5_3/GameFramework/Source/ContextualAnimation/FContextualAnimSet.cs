namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains AnimTracks for each role in the interaction.</summary>
[CppInclude("ContextualAnimSceneAsset.h")]
public partial struct FContextualAnimSet {
	public TArray<FContextualAnimTrack> Tracks;
	public TMap<FName,FTransform> WarpPoints;
	public float RandomWeight;
}
