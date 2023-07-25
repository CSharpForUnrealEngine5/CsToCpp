#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
///<summary>Filters an item array by a list of tags</summary>
public partial struct FRigUnit_FilterItemsByMetadataTags {
// RigUnit_FilterItemsByMetadataTags
	public TArray<FRigElementKey> Items;
	public TArray<string> Tags;
	public bool Inclusive;
	public TArray<FRigElementKey> Result;
	public TArray<FCachedRigElement> CachedIndices;
}
