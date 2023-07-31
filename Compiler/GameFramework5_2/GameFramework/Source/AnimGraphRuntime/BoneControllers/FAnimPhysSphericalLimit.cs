#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_AnimDynamics.h")]
public partial struct FAnimPhysSphericalLimit {
	public FBoneReference DrivingBone;
	public FVector SphereLocalOffset;
	public float LimitRadius;
	public ESphericalLimitType LimitType;
}
