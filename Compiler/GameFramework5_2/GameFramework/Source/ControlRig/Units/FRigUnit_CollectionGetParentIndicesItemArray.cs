namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns an array of relative parent indices for each item. Several options here</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionGetParentIndicesItemArray {
	public TArray<FRigElementKey> Items;
	public TArray<int> ParentIndices;
}
