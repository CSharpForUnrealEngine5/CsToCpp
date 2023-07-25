#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
///<summary>Returns the metadata tags on an item</summary>
public partial struct FRigUnit_GetMetadataTags {
// RigUnit_GetMetadataTags
	public FRigElementKey Item;
	public TArray<string> Tags;
	public FCachedRigElement CachedIndex;
}
