namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filters an item array by a list of tags</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_FilterItemsByMetadataTags {
	public TArray<FRigElementKey> Items;
	public TArray<FName> Tags;
	public bool Inclusive;
	public TArray<FRigElementKey> Result;
	public TArray<FCachedRigElement> CachedIndices;
}
