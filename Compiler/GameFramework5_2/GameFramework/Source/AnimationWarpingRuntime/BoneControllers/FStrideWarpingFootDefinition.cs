#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Foot definition specifying the IK/FK foot bones and Thigh bone</summary>
[CppInclude("BoneControllers/AnimNode_StrideWarping.h")]
public partial struct FStrideWarpingFootDefinition {
	public FBoneReference IKFootBone;
	public FBoneReference FKFootBone;
	public FBoneReference ThighBone;
}
