#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Collection.h")]
///<summary>Replaces all names within the item array</summary>
public partial struct FRigUnit_CollectionReplaceItemsArray {
// RigUnit_CollectionReplaceItemsArray
	public TArray<FRigElementKey> Items;
	public string Old;
	public string New;
	public bool RemoveInvalidItems;
	public bool bAllowDuplicates;
	public TArray<FRigElementKey> Result;
}
