#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the metadata tags on an item</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_GetMetadataTags {
	public FRigElementKey Item;
	public TArray<string> Tags;
	public FCachedRigElement CachedIndex;
}
