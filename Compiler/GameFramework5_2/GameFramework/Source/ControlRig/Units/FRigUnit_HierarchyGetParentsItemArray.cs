#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
///<summary>Returns the item's parents</summary>
public partial struct FRigUnit_HierarchyGetParentsItemArray {
// RigUnit_HierarchyGetParentsItemArray
	public FRigElementKey Child;
	public bool bIncludeChild;
	public bool bReverse;
	public TArray<FRigElementKey> Parents;
	public FCachedRigElement CachedChild;
	public FRigElementKeyCollection CachedParents;
}
