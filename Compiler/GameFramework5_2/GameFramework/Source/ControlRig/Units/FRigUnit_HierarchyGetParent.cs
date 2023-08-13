namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the item&#39;s parent</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_HierarchyGetParent {
	public FRigElementKey Child;
	public FRigElementKey Parent;
	public FCachedRigElement CachedChild;
	public FCachedRigElement CachedParent;
}
