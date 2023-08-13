namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Distributes rotations provided along a chain.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_DistributeRotation.h")]
public partial struct FRigUnit_DistributeRotation {
	public string StartBone;
	public string EndBone;
	public TArray<FRigUnit_DistributeRotation_Rotation> Rotations;
	public ERigVMAnimEasingType RotationEaseType;
	public float Weight;
	public bool bPropagateToChildren;
	public FRigUnit_DistributeRotation_WorkData WorkData;
}
