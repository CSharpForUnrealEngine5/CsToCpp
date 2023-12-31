namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns a collection provided a specific array of items.</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionItems {
	public TArray<FRigElementKey> Items;
	public bool bAllowDuplicates;
	public FRigElementKeyCollection Collection;
}
