#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pose data</summary>
[CppInclude("Animation/PoseAsset.h")]
public partial struct FPoseData {
	public TArray<FTransform> SourceLocalSpacePose;
	public TArray<float> SourceCurveData;
	public TArray<FTransform> LocalSpacePose;
	public TArray<float> CurveData;
}
