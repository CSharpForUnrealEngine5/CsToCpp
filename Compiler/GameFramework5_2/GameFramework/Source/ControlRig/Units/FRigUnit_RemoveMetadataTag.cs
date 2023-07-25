#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
///<summary>Removes a tag from an item</summary>
public partial struct FRigUnit_RemoveMetadataTag {
// RigUnit_RemoveMetadataTag
	public FRigElementKey Item;
	public string Tag;
	public bool Removed;
	public FCachedRigElement CachedIndex;
}
