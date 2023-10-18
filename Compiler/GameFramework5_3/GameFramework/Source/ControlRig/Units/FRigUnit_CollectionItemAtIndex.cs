namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns a single item within a collection by index</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionItemAtIndex {
	public FRigElementKeyCollection Collection;
	public int Index;
	public FRigElementKey Item;
}
