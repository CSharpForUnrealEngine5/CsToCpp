#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Removes an existing metadata filed from an item</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_RemoveMetadata {
	public FRigElementKey Item;
	public string Name;
	public bool Removed;
	public FCachedRigElement CachedIndex;
}
