#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the item&#39;s parents</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_HierarchyGetParents {
	public FRigElementKey Child;
	public bool bIncludeChild;
	public bool bReverse;
	public FRigElementKeyCollection Parents;
	public FCachedRigElement CachedChild;
	public FRigElementKeyCollection CachedParents;
}
