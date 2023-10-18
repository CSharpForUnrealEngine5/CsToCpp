namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Removes an existing metadata filed from an item</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_RemoveAllMetadata {
	public FRigElementKey Item;
	public bool Removed;
	public FCachedRigElement CachedIndex;
}
