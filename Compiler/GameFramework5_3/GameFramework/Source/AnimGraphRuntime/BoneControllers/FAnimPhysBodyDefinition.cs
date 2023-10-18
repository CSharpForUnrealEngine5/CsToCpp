namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_AnimDynamics.h")]
public partial struct FAnimPhysBodyDefinition {
	public FBoneReference BoundBone;
	public FVector BoxExtents;
	public FVector LocalJointOffset;
	public FAnimPhysConstraintSetup ConstraintSetup;
	public AnimPhysCollisionType CollisionType;
	public float SphereCollisionRadius;
}
