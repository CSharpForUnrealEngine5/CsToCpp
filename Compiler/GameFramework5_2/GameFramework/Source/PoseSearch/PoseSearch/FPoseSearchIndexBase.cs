#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchIndex.h")]
///<summary>case class for FPoseSearchIndex. building block used to gather data for data mining and calculate weights, pca, kdtree stuff</summary>
public partial struct FPoseSearchIndexBase {
// PoseSearchIndexBase
	public int NumPoses;
	public TArray<float> Values;
	public TArray<FPoseSearchPoseMetadata> PoseMetadata;
	public EPoseSearchPoseFlags OverallFlags;
	public TArray<FPoseSearchIndexAsset> Assets;
	public float MinCostAddend;
}
