#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchFeatureChannel_Position.h")]
public partial class UPoseSearchFeatureChannel_Position : UPoseSearchFeatureChannel {
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
}
