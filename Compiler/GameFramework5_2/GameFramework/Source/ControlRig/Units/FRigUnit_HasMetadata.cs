#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true if a given item in the hierarchy has a specific set of metadata</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_HasMetadata {
	public FRigElementKey Item;
	public string Name;
	public ERigMetadataType Type;
	public bool Found;
	public FCachedRigElement CachedIndex;
}
