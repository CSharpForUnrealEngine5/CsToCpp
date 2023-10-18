namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true if a given item in the hierarchy has all of the provided tags</summary>
[CppInclude("Units/Hierarchy/RigUnit_Metadata.h")]
public partial struct FRigUnit_HasMetadataTagArray {
	public FRigElementKey Item;
	public TArray<FName> Tags;
	public bool Found;
	public FCachedRigElement CachedIndex;
}
