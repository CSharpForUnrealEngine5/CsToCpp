namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replaces the text within the name of the item</summary>
[CppInclude("Units/Execution/RigUnit_Item.h")]
public partial struct FRigUnit_ItemReplace {
	public FRigElementKey Item;
	public FName Old;
	public FName New;
	public FRigElementKey Result;
}
