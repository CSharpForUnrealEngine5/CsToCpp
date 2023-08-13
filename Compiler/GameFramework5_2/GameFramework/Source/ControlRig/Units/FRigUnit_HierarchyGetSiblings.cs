namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the item&#39;s siblings</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_HierarchyGetSiblings {
	public FRigElementKey Item;
	public bool bIncludeItem;
	public FRigElementKeyCollection Siblings;
	public FCachedRigElement CachedItem;
	public FRigElementKeyCollection CachedSiblings;
}
