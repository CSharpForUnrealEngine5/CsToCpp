namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the item&#39;s children</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_HierarchyGetChildren {
	public FRigElementKey Parent;
	public bool bIncludeParent;
	public bool bRecursive;
	public FRigElementKeyCollection Children;
	public FCachedRigElement CachedParent;
	public FRigElementKeyCollection CachedChildren;
}
