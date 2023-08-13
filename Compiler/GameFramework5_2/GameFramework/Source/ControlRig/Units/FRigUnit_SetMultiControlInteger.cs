namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetMultiControlInteger is used to perform a change in the hierarchy by setting multiple controls&#39; integer value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetMultiControlInteger {
	public TArray<FRigUnit_SetMultiControlInteger_Entry> Entries;
	public float Weight;
	public TArray<FCachedRigElement> CachedControlIndices;
}
