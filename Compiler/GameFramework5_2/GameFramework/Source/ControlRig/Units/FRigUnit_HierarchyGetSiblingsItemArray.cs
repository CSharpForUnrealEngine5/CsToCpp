#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
///<summary>Returns the item's siblings</summary>
public partial struct FRigUnit_HierarchyGetSiblingsItemArray {
// RigUnit_HierarchyGetSiblingsItemArray
	public FRigElementKey Item;
	public bool bIncludeItem;
	public TArray<FRigElementKey> Siblings;
	public FCachedRigElement CachedItem;
	public FRigElementKeyCollection CachedSiblings;
}
