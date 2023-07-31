#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replaces all names within the item array</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionReplaceItemsArray {
	public TArray<FRigElementKey> Items;
	public string Old;
	public string New;
	public bool RemoveInvalidItems;
	public bool bAllowDuplicates;
	public TArray<FRigElementKey> Result;
}
