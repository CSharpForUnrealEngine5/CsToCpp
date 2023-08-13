namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Creates an item array based on a first and last item within a chain.</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionChainArray {
	public FRigElementKey FirstItem;
	public FRigElementKey LastItem;
	public bool Reverse;
	public TArray<FRigElementKey> Items;
}
