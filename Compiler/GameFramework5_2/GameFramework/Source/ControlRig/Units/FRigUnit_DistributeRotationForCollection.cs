#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_DistributeRotation.h")]
///<summary>Distributes rotations provided across a collection of items.</summary>
public partial struct FRigUnit_DistributeRotationForCollection {
// RigUnit_DistributeRotationForCollection
	public FRigElementKeyCollection Items;
	public TArray<FRigUnit_DistributeRotation_Rotation> Rotations;
	public ERigVMAnimEasingType RotationEaseType;
	public float Weight;
	public FRigUnit_DistributeRotation_WorkData WorkData;
}
