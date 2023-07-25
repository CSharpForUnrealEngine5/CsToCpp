#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchFeatureChannel_Velocity.h")]
public partial class UPoseSearchFeatureChannel_Velocity : UPoseSearchFeatureChannel {
// PoseSearchFeatureChannel_Velocity
	public FBoneReference Bone;
	public float Weight;
	public float SampleTimeOffset;
	public short SchemaBoneIdx;
	public int ColorPresetIndex;
	public EInputQueryPose InputQueryPose;
	public bool bUseCharacterSpaceVelocities;
	public bool bNormalize;
}
