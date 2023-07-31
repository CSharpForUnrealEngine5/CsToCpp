#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the item&#39;s siblings</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_HierarchyGetSiblingsItemArray {
	public FRigElementKey Item;
	public bool bIncludeItem;
	public TArray<FRigElementKey> Siblings;
	public FCachedRigElement CachedItem;
	public FRigElementKeyCollection CachedSiblings;
}
