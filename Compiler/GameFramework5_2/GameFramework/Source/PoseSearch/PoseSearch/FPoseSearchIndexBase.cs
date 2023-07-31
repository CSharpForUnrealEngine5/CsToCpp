#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>case class for FPoseSearchIndex. building block used to gather data for data mining and calculate weights, pca, kdtree stuff</summary>
[CppInclude("PoseSearch/PoseSearchIndex.h")]
public partial struct FPoseSearchIndexBase {
	public int NumPoses;
	public TArray<float> Values;
	public TArray<FPoseSearchPoseMetadata> PoseMetadata;
	public EPoseSearchPoseFlags OverallFlags;
	public TArray<FPoseSearchIndexAsset> Assets;
	public float MinCostAddend;
}
