#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
///<summary>Compares two pose caches and compares their values.</summary>
public partial struct FRigUnit_PoseGetDelta {
// RigUnit_PoseGetDelta
	public FRigPose PoseA;
	public FRigPose PoseB;
	public float PositionThreshold;
	public float RotationThreshold;
	public float ScaleThreshold;
	public float CurveThreshold;
	public ERigElementType ElementType;
	public ERigVMTransformSpace Space;
	public FRigElementKeyCollection ItemsToCompare;
	public bool PosesAreEqual;
	public FRigElementKeyCollection ItemsWithDelta;
}
