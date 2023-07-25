#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchIndex.h")]
///<summary>This is kept for each pose in the search index along side the feature vector values and is used to influence the search.</summary>
public partial struct FPoseSearchPoseMetadata {
// PoseSearchPoseMetadata
	public EPoseSearchPoseFlags Flags;
	public float CostAddend;
	public float ContinuingPoseCostAddend;
	public int AssetIndex;
}
