namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per foot definitions</summary>
[CppInclude("BoneControllers/AnimNode_SlopeWarping.h")]
public partial struct FSlopeWarpingFootDefinition {
	public FBoneReference IKFootBone;
	public FBoneReference FKFootBone;
	public int NumBonesInLimb;
	public float FootSize;
}
