#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneAsset.h")]
///<summary>Contains AnimTracks for each role in the interaction.</summary>
public partial struct FContextualAnimSet {
// ContextualAnimSet
	public TArray<FContextualAnimTrack> Tracks;
	public TArray<FTransform> ScenePivots;
	public float RandomWeight;
}
