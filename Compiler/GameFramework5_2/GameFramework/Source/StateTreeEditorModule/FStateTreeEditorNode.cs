#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeEditorNode.h")]
///<summary>Base for Evaluator, Task and Condition nodes.</summary>
public partial struct FStateTreeEditorNode {
// StateTreeEditorNode
	public FInstancedStruct Node;
	public FInstancedStruct Instance;
	public UObject InstanceObject;
	public FGuid ID;
	public byte ConditionIndent;
	public EStateTreeConditionOperand ConditionOperand;
}
