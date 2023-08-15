namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_FootPlacement.h")]
public partial struct FFootPlacemenLegDefinition {
	public FBoneReference FKFootBone;
	public FBoneReference IKFootBone;
	public FBoneReference BallBone;
	public int NumBonesInLimb;
	public FName SpeedCurveName;
	public FName DisableLockCurveName;
}
