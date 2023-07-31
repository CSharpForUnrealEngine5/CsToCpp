#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Distributes rotations provided across a collection of items.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_DistributeRotation.h")]
public partial struct FRigUnit_DistributeRotationForCollection {
	public FRigElementKeyCollection Items;
	public TArray<FRigUnit_DistributeRotation_Rotation> Rotations;
	public ERigVMAnimEasingType RotationEaseType;
	public float Weight;
	public FRigUnit_DistributeRotation_WorkData WorkData;
}
