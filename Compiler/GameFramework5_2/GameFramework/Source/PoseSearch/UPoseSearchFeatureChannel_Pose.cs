#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchFeatureChannel_Pose.h")]
///<summary>UPoseSearchFeatureChannel_Pose</summary>
public partial class UPoseSearchFeatureChannel_Pose : UPoseSearchFeatureChannel_GroupBase {
// PoseSearchFeatureChannel_Pose
	public float Weight;
	public TArray<FPoseSearchBone> SampledBones;
	public TArray<short> SchemaBoneIdx;
	public EInputQueryPose InputQueryPose;
	public bool bUseCharacterSpaceVelocities;
	public TArray<UPoseSearchFeatureChannel> SubChannels;
}
