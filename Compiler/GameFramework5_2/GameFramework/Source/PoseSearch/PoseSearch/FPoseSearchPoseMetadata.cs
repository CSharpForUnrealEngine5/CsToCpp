#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is kept for each pose in the search index along side the feature vector values and is used to influence the search.</summary>
[CppInclude("PoseSearch/PoseSearchIndex.h")]
public partial struct FPoseSearchPoseMetadata {
	public EPoseSearchPoseFlags Flags;
	public float CostAddend;
	public float ContinuingPoseCostAddend;
	public int AssetIndex;
}
