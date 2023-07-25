#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Collection.h")]
///<summary>Given a collection of items, execute iteratively across all items in a given collection</summary>
public partial struct FRigUnit_CollectionLoop {
// RigUnit_CollectionLoop
	public string BlockToRun;
	public FRigElementKeyCollection Collection;
	public FRigElementKey Item;
	public int Index;
	public int Count;
	public float Ratio;
	public FControlRigExecuteContext Completed;
}
