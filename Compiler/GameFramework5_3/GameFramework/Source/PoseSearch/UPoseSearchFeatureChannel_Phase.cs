namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchFeatureChannel_Phase.h")]
public partial class UPoseSearchFeatureChannel_Phase : UPoseSearchFeatureChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Bone</summary>
	public FBoneReference Bone;
	///<summary>Weight</summary>
	public float Weight;
	///<summary>SchemaBoneIdx</summary>
	public short SchemaBoneIdx;
	///<summary>DebugColor</summary>
	public FLinearColor DebugColor;
	///<summary>InputQueryPose</summary>
	public EInputQueryPose InputQueryPose;
}
