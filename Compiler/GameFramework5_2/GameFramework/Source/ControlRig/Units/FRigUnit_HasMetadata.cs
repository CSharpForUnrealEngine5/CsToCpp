#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
///<summary>Returns true if a given item in the hierarchy has a specific set of metadata</summary>
public partial struct FRigUnit_HasMetadata {
// RigUnit_HasMetadata
	public FRigElementKey Item;
	public string Name;
	public ERigMetadataType Type;
	public bool Found;
	public FCachedRigElement CachedIndex;
}
