#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetMultiControlInteger is used to perform a change in the hierarchy by setting multiple controls' integer value.</summary>
public partial struct FRigUnit_SetMultiControlInteger {
// RigUnit_SetMultiControlInteger
	public TArray<FRigUnit_SetMultiControlInteger_Entry> Entries;
	public float Weight;
	public TArray<FCachedRigElement> CachedControlIndices;
}
