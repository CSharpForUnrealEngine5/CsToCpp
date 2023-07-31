#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct of StateTree Conditions, Evaluators, and Tasks.</summary>
[CppInclude("StateTreeNodeBase.h")]
public partial struct FStateTreeNodeBase {
	public string Name;
	public FStateTreeIndex16 BindingsBatch;
	public FStateTreeIndex16 DataViewIndex;
	public FStateTreeIndex16 InstanceIndex;
	public bool bInstanceIsObject;
}
