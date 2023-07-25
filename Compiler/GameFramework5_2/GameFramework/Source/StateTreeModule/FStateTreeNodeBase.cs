#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeNodeBase.h")]
///<summary>Base struct of StateTree Conditions, Evaluators, and Tasks.</summary>
public partial struct FStateTreeNodeBase {
// StateTreeNodeBase
	public string Name;
	public FStateTreeIndex16 BindingsBatch;
	public FStateTreeIndex16 DataViewIndex;
	public FStateTreeIndex16 InstanceIndex;
	public bool bInstanceIsObject;
}
