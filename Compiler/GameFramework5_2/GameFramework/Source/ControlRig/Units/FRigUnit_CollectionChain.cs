#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Creates a collection based on a first and last item within a chain.</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionChain {
	public FRigElementKey FirstItem;
	public FRigElementKey LastItem;
	public bool Reverse;
	public FRigElementKeyCollection Collection;
}
