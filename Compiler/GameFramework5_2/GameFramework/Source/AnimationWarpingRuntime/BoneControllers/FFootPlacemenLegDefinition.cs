#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_FootPlacement.h")]
public partial struct FFootPlacemenLegDefinition {
	public FBoneReference FKFootBone;
	public FBoneReference IKFootBone;
	public FBoneReference BallBone;
	public int NumBonesInLimb;
	public string SpeedCurveName;
	public string DisableLockCurveName;
}
