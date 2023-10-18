namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true or false if a given item exists</summary>
[CppInclude("Units/Execution/RigUnit_Item.h")]
public partial struct FRigUnit_ItemExists {
	public FRigElementKey Item;
	public bool Exists;
	public FCachedRigElement CachedIndex;
}
