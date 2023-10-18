namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_AnimDynamics.h")]
public partial struct FAnimPhysSphericalLimit {
	public FBoneReference DrivingBone;
	public FVector SphereLocalOffset;
	public float LimitRadius;
	public ESphericalLimitType LimitType;
}
