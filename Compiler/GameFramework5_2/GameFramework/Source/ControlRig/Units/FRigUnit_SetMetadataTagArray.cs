namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets multiple tags on an item</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_SetMetadataTagArray {
	public FRigElementKey Item;
	public TArray<string> Tags;
	public FCachedRigElement CachedIndex;
}
