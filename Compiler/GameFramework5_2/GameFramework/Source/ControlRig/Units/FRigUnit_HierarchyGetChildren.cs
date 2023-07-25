#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
///<summary>Returns the item's children</summary>
public partial struct FRigUnit_HierarchyGetChildren {
// RigUnit_HierarchyGetChildren
	public FRigElementKey Parent;
	public bool bIncludeParent;
	public bool bRecursive;
	public FRigElementKeyCollection Children;
	public FCachedRigElement CachedParent;
	public FRigElementKeyCollection CachedChildren;
}
