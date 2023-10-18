namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets a single tag on an item</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_SetMetadataTag {
	public FRigElementKey Item;
	public FName Tag;
	public FCachedRigElement CachedIndex;
}
