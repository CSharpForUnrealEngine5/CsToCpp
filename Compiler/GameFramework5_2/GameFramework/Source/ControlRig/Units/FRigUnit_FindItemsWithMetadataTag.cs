namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns all items with a specific tag</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_FindItemsWithMetadataTag {
	public string Tag;
	public TArray<FRigElementKey> Items;
}
