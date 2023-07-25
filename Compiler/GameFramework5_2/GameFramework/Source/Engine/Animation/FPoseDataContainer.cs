#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/PoseAsset.h")]
///<summary>Pose data container</summary>
public partial struct FPoseDataContainer {
// PoseDataContainer
	public TArray<FSmartName> PoseNames;
	public TArray<string> Tracks;
	public TArray<int> TrackBoneIndices;
	public TArray<FPoseAssetInfluences> TrackPoseInfluenceIndices;
	public TArray<FPoseData> Poses;
	public TArray<FAnimCurveBase> Curves;
}
