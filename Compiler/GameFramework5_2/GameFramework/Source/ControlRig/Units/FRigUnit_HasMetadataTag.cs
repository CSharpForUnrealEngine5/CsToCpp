namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true if a given item in the hierarchy has a specific tag stored in the metadata</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_HasMetadataTag {
	public FRigElementKey Item;
	public string Tag;
	public bool Found;
	public FCachedRigElement CachedIndex;
}
