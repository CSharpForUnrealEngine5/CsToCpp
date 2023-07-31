#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Creates a collection based on the direct or recursive children</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionChildren {
	public FRigElementKey Parent;
	public bool bIncludeParent;
	public bool bRecursive;
	public ERigElementType TypeToSearch;
	public FRigElementKeyCollection Collection;
}
