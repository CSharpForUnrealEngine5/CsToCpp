namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds an element to an existing collection</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionAddItem {
	public FRigElementKeyCollection Collection;
	public FRigElementKey Item;
	public FRigElementKeyCollection Result;
}
