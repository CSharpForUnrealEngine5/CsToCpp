namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replaces all names within the item array</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionReplaceItemsArray {
	public TArray<FRigElementKey> Items;
	public FName Old;
	public FName New;
	public bool RemoveInvalidItems;
	public bool bAllowDuplicates;
	public TArray<FRigElementKey> Result;
}
