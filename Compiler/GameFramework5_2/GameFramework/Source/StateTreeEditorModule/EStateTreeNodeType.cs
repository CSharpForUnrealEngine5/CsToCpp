namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeEditorNode.h")]
public enum EStateTreeNodeType {
	EnterCondition=0,
	Evaluator=1,
	Task=2,
	TransitionCondition=3,
	StateParameters=4,
}
