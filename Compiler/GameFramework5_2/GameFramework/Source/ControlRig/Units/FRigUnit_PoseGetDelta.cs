namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compares two pose caches and compares their values.</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_PoseGetDelta {
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
