namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetMultiControlFloat is used to perform a change in the hierarchy by setting multiple controls&#39; float value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetMultiControlFloat {
	public TArray<FRigUnit_SetMultiControlFloat_Entry> Entries;
	public float Weight;
	public TArray<FCachedRigElement> CachedControlIndices;
}
