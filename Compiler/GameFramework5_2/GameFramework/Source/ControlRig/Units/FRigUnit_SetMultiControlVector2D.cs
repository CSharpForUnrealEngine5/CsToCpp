#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
///<summary>SetMultiControlVector2D is used to perform a change in the hierarchy by setting multiple controls' vector2D value.</summary>
public partial struct FRigUnit_SetMultiControlVector2D {
// RigUnit_SetMultiControlVector2D
	public TArray<FRigUnit_SetMultiControlVector2D_Entry> Entries;
	public float Weight;
	public TArray<FCachedRigElement> CachedControlIndices;
}
