namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlDrivenList is used to retrieve the list of affected controls of an indirect control</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlDrivenList.h")]
public partial struct FRigUnit_GetControlDrivenList {
	public string Control;
	public TArray<FRigElementKey> Driven;
	public FCachedRigElement CachedControlIndex;
}
