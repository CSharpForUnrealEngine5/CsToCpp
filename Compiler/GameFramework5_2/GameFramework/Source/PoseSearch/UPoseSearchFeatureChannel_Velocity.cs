#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchFeatureChannel_Velocity.h")]
public partial class UPoseSearchFeatureChannel_Velocity : UPoseSearchFeatureChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Bone</summary>
	public FBoneReference Bone;
	///<summary>Weight</summary>
	public float Weight;
	///<summary>SampleTimeOffset</summary>
	public float SampleTimeOffset;
	///<summary>SchemaBoneIdx</summary>
	public short SchemaBoneIdx;
	///<summary>ColorPresetIndex</summary>
	public int ColorPresetIndex;
	///<summary>InputQueryPose</summary>
	public EInputQueryPose InputQueryPose;
	///<summary>if bUseCharacterSpaceVelocities is true, velocities will be calculated from the positions in character space, otherwise they will be calculated using global space positions</summary>
	public bool bUseCharacterSpaceVelocities;
	///<summary>if bNormalize is true, velocity will be clamped to a maximum size of one (UPoseSearchFeatureChannel_Velocity will be matching the &quot;direction&quot; of the velocity)</summary>
	public bool bNormalize;
}
