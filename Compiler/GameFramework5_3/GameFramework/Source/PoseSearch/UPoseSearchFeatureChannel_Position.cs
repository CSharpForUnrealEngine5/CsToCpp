namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearchFeatureChannel_Position.h")]
public partial class UPoseSearchFeatureChannel_Position : UPoseSearchFeatureChannel {
	public static UClass StaticClass() {return default;}
	///<summary>Bone</summary>
	public FBoneReference Bone;
	///<summary>OriginBone</summary>
	public FBoneReference OriginBone;
	///<summary>Weight</summary>
	public float Weight;
	///<summary>SampleTimeOffset</summary>
	public float SampleTimeOffset;
	///<summary>SchemaBoneIdx</summary>
	public short SchemaBoneIdx;
	///<summary>SchemaOriginBoneIdx</summary>
	public short SchemaOriginBoneIdx;
	///<summary>DebugColor</summary>
	public FLinearColor DebugColor;
	///<summary>InputQueryPose</summary>
	public EInputQueryPose InputQueryPose;
	///<summary>ComponentStripping</summary>
	public EComponentStrippingVector ComponentStripping;
	///<summary>PermutationTimeType</summary>
	public EPermutationTimeType PermutationTimeType;
}
