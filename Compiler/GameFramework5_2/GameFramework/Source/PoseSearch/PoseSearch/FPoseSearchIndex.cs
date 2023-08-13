namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A search index for animation poses. The structure of the search index is determined by its UPoseSearchSchema.</summary>
[CppInclude("PoseSearch/PoseSearchIndex.h")]
public partial struct FPoseSearchIndex {
	public TArray<float> PCAValues;
	public TArray<float> PCAProjectionMatrix;
	public TArray<float> Mean;
	public TArray<float> WeightsSqrt;
	public float PCAExplainedVariance;
	public TArray<float> Deviation;
}
