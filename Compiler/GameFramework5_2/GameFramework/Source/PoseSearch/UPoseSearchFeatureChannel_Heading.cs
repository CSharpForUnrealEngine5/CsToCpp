namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchFeatureChannel_Heading.h")]
public partial class UPoseSearchFeatureChannel_Heading : UPoseSearchFeatureChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Bone</summary>
	public FBoneReference Bone;
	///<summary>Weight</summary>
	public float Weight;
	///<summary>SampleTimeOffset</summary>
	public float SampleTimeOffset;
	///<summary>HeadingAxis</summary>
	public EHeadingAxis HeadingAxis;
	///<summary>SchemaBoneIdx</summary>
	public short SchemaBoneIdx;
	///<summary>ColorPresetIndex</summary>
	public int ColorPresetIndex;
	///<summary>InputQueryPose</summary>
	public EInputQueryPose InputQueryPose;
}
