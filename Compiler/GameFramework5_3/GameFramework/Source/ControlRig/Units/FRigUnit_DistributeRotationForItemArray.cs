namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Distributes rotations provided across a array of items.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_DistributeRotation.h")]
public partial struct FRigUnit_DistributeRotationForItemArray {
	public TArray<FRigElementKey> Items;
	public TArray<FRigUnit_DistributeRotation_Rotation> Rotations;
	public ERigVMAnimEasingType RotationEaseType;
	public float Weight;
	public FRigUnit_DistributeRotation_WorkData WorkData;
}
