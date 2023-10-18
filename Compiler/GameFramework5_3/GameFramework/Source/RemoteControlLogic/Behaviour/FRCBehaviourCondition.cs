namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct representing a single Condition</summary>
[CppInclude("Behaviour/Builtin/Conditional/RCBehaviourConditional.h")]
public partial struct FRCBehaviourCondition {
	public ERCBehaviourConditionType ConditionType;
	public URCVirtualPropertySelfContainer Comparand;
}
