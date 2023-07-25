#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
///<summary>Returns true if a given item in the hierarchy has a specific tag stored in the metadata</summary>
public partial struct FRigUnit_HasMetadataTag {
// RigUnit_HasMetadataTag
	public FRigElementKey Item;
	public string Tag;
	public bool Found;
	public FCachedRigElement CachedIndex;
}
