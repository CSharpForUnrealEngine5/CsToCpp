#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filters an item array by a list of tags</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_FilterItemsByMetadataTags {
	public TArray<FRigElementKey> Items;
	public TArray<string> Tags;
	public bool Inclusive;
	public TArray<FRigElementKey> Result;
	public TArray<FCachedRigElement> CachedIndices;
}
