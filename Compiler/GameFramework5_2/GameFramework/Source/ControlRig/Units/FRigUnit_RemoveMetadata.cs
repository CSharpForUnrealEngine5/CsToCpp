#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
///<summary>Removes an existing metadata filed from an item</summary>
public partial struct FRigUnit_RemoveMetadata {
// RigUnit_RemoveMetadata
	public FRigElementKey Item;
	public string Name;
	public bool Removed;
	public FCachedRigElement CachedIndex;
}
