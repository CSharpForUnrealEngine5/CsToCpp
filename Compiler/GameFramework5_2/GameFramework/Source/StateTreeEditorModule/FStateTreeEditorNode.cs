namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base for Evaluator, Task and Condition nodes.</summary>
[CppInclude("StateTreeEditorNode.h")]
public partial struct FStateTreeEditorNode {
	public FInstancedStruct Node;
	public FInstancedStruct Instance;
	public UObject InstanceObject;
	public FGuid ID;
	public byte ConditionIndent;
	public EStateTreeConditionOperand ConditionOperand;
}
