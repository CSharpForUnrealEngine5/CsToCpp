#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_AnimDynamics.h")]
public partial struct FAnimPhysBodyDefinition {
// AnimPhysBodyDefinition
	public FBoneReference BoundBone;
	public FVector BoxExtents;
	public FVector LocalJointOffset;
	public FAnimPhysConstraintSetup ConstraintSetup;
	public AnimPhysCollisionType CollisionType;
	public float SphereCollisionRadius;
}
