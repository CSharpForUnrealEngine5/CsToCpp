#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pose data container</summary>
[CppInclude("Animation/PoseAsset.h")]
public partial struct FPoseDataContainer {
	public TArray<FSmartName> PoseNames;
	public TArray<string> Tracks;
	public TArray<int> TrackBoneIndices;
	public TArray<FPoseAssetInfluences> TrackPoseInfluenceIndices;
	public TArray<FPoseData> Poses;
	public TArray<FAnimCurveBase> Curves;
}
