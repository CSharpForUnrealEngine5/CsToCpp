namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPoseSearchFeatureChannel_Pose</summary>
[CppInclude("PoseSearchFeatureChannel_Pose.h")]
public partial class UPoseSearchFeatureChannel_Pose : UPoseSearchFeatureChannel_GroupBase {
	public static UClass StaticClass() {return default;}
	///<summary>Weight</summary>
	public float Weight;
	///<summary>SampledBones</summary>
	public TArray<FPoseSearchBone> SampledBones;
	///<summary>SchemaBoneIdx</summary>
	public TArray<short> SchemaBoneIdx;
	///<summary>InputQueryPose</summary>
	public EInputQueryPose InputQueryPose;
	///<summary>if bUseCharacterSpaceVelocities is true, velocities will be calculated from the positions in character space, otherwise they will be calculated using global space positions</summary>
	public bool bUseCharacterSpaceVelocities;
	///<summary>SubChannels</summary>
	public TArray<UPoseSearchFeatureChannel> SubChannels;
}
