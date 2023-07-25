#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetMultiControlBool is used to perform a change in the hierarchy by setting multiple controls' bool value.</summary>
public partial struct FRigUnit_SetMultiControlBool {
// RigUnit_SetMultiControlBool
	public TArray<FRigUnit_SetMultiControlBool_Entry> Entries;
	public TArray<FCachedRigElement> CachedControlIndices;
}
