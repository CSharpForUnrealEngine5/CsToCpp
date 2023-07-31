#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Removes a tag from an item</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_RemoveMetadataTag {
	public FRigElementKey Item;
	public string Tag;
	public bool Removed;
	public FCachedRigElement CachedIndex;
}
