#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchIndex.h")]
///<summary>A search index for animation poses. The structure of the search index is determined by its UPoseSearchSchema.</summary>
public partial struct FPoseSearchIndex {
// PoseSearchIndex
	public TArray<float> PCAValues;
	public TArray<float> PCAProjectionMatrix;
	public TArray<float> Mean;
	public TArray<float> WeightsSqrt;
	public float PCAExplainedVariance;
	public TArray<float> Deviation;
}
