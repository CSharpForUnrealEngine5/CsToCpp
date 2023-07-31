#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given a collection of items, execute iteratively across all items in a given collection</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionLoop {
	public string BlockToRun;
	public FRigElementKeyCollection Collection;
	public FRigElementKey Item;
	public int Index;
	public int Count;
	public float Ratio;
	public FControlRigExecuteContext Completed;
}
