namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetMultiControlBool is used to perform a change in the hierarchy by setting multiple controls&#39; bool value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetMultiControlBool {
	public TArray<FRigUnit_SetMultiControlBool_Entry> Entries;
	public TArray<FCachedRigElement> CachedControlIndices;
}
