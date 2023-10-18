namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pose data container</summary>
[CppInclude("Animation/PoseAsset.h")]
public partial struct FPoseDataContainer {
	public TArray<FSmartName> PoseNames_DEPRECATED;
	public TArray<FName> PoseFNames;
	public TArray<FName> Tracks;
	public TArray<int> TrackBoneIndices;
	public TArray<FPoseAssetInfluences> TrackPoseInfluenceIndices;
	public TArray<FPoseData> Poses;
	public TArray<FAnimCurveBase> Curves;
}
