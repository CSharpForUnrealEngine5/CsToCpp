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
