#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetMultiControlRotator is used to perform a change in the hierarchy by setting multiple controls' rotator value.</summary>
public partial struct FRigUnit_SetMultiControlRotator {
// RigUnit_SetMultiControlRotator
	public TArray<FRigUnit_SetMultiControlRotator_Entry> Entries;
	public float Weight;
	public TArray<FCachedRigElement> CachedControlIndices;
}
