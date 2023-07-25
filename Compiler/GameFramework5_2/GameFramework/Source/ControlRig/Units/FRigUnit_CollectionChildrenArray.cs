#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Collection.h")]
///<summary>Creates an item array based on the direct or recursive children</summary>
public partial struct FRigUnit_CollectionChildrenArray {
// RigUnit_CollectionChildrenArray
	public FRigElementKey Parent;
	public bool bIncludeParent;
	public bool bRecursive;
	public ERigElementType TypeToSearch;
	public TArray<FRigElementKey> Items;
}
