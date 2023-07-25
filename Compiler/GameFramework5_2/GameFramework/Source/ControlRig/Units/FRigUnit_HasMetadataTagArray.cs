#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
///<summary>Returns true if a given item in the hierarchy has all of the provided tags</summary>
public partial struct FRigUnit_HasMetadataTagArray {
// RigUnit_HasMetadataTagArray
	public FRigElementKey Item;
	public TArray<string> Tags;
	public bool Found;
	public FCachedRigElement CachedIndex;
}
