#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Collection.h")]
///<summary>Creates a collection based on the direct or recursive children</summary>
public partial struct FRigUnit_CollectionChildren {
// RigUnit_CollectionChildren
	public FRigElementKey Parent;
	public bool bIncludeParent;
	public bool bRecursive;
	public ERigElementType TypeToSearch;
	public FRigElementKeyCollection Collection;
}
