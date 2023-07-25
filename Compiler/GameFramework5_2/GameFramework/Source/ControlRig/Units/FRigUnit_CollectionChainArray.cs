#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Collection.h")]
///<summary>Creates an item array based on a first and last item within a chain.</summary>
public partial struct FRigUnit_CollectionChainArray {
// RigUnit_CollectionChainArray
	public FRigElementKey FirstItem;
	public FRigElementKey LastItem;
	public bool Reverse;
	public TArray<FRigElementKey> Items;
}
