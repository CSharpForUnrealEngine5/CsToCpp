#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Collection.h")]
///<summary>Creates a collection based on a first and last item within a chain.</summary>
public partial struct FRigUnit_CollectionChain {
// RigUnit_CollectionChain
	public FRigElementKey FirstItem;
	public FRigElementKey LastItem;
	public bool Reverse;
	public FRigElementKeyCollection Collection;
}
