#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetMultiControlFloat is used to perform a change in the hierarchy by setting multiple controls' float value.</summary>
public partial struct FRigUnit_SetMultiControlFloat {
// RigUnit_SetMultiControlFloat
	public TArray<FRigUnit_SetMultiControlFloat_Entry> Entries;
	public float Weight;
	public TArray<FCachedRigElement> CachedControlIndices;
}
