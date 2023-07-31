#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetMultiControlVector2D is used to perform a change in the hierarchy by setting multiple controls&#39; vector2D value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetMultiControlVector2D {
	public TArray<FRigUnit_SetMultiControlVector2D_Entry> Entries;
	public float Weight;
	public TArray<FCachedRigElement> CachedControlIndices;
}
