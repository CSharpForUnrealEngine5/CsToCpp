namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetMultiControlRotator is used to perform a change in the hierarchy by setting multiple controls&#39; rotator value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetMultiControlRotator {
	public TArray<FRigUnit_SetMultiControlRotator_Entry> Entries;
	public float Weight;
	public TArray<FCachedRigElement> CachedControlIndices;
}
