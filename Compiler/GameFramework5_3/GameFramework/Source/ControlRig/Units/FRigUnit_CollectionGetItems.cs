namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns an array of items provided a collection</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionGetItems {
	public FRigElementKeyCollection Collection;
	public TArray<FRigElementKey> Items;
}
