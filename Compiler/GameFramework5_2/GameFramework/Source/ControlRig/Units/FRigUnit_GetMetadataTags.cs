namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the metadata tags on an item</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_GetMetadataTags {
	public FRigElementKey Item;
	public TArray<FName> Tags;
	public FCachedRigElement CachedIndex;
}
