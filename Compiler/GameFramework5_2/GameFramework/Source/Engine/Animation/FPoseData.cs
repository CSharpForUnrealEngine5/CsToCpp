#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/PoseAsset.h")]
///<summary>Pose data</summary>
public partial struct FPoseData {
// PoseData
	public TArray<FTransform> SourceLocalSpacePose;
	public TArray<float> SourceCurveData;
	public TArray<FTransform> LocalSpacePose;
	public TArray<float> CurveData;
}
