#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchDatabaseEditorReflection.h")]
public partial class UPoseSearchDatabaseStatistics : UObject {
// PoseSearchDatabaseStatistics
	public uint AnimationSequences;
	public uint TotalAnimationPosesInFrames;
	public string TotalAnimationPosesInTime;
	public uint SearchableFrames;
	public string SearchableTime;
	public double AverageVelocity;
	public double MaxVelocity;
	public double AverageAcceleration;
	public double MaxAcceleration;
	public float ExplainedVariance;
	public string EstimatedDatabaseSize;
	public string ValuesSize;
	public string PCAValuesSize;
	public string KDTreeSize;
	public string PoseMetadataSize;
	public string AssetsSize;
}
