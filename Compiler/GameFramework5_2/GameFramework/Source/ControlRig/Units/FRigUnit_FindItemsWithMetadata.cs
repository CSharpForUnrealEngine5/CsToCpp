#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns all items containing a specific set of metadata</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_FindItemsWithMetadata {
	public string Name;
	public ERigMetadataType Type;
	public TArray<FRigElementKey> Items;
}
