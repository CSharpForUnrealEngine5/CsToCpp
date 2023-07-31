#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Creates an item array based on the direct or recursive children</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionChildrenArray {
	public FRigElementKey Parent;
	public bool bIncludeParent;
	public bool bRecursive;
	public ERigElementType TypeToSearch;
	public TArray<FRigElementKey> Items;
}
