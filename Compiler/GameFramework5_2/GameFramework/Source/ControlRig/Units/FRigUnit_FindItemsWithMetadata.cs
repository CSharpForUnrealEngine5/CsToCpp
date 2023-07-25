#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
///<summary>Returns all items containing a specific set of metadata</summary>
public partial struct FRigUnit_FindItemsWithMetadata {
// RigUnit_FindItemsWithMetadata
	public string Name;
	public ERigMetadataType Type;
	public TArray<FRigElementKey> Items;
}
