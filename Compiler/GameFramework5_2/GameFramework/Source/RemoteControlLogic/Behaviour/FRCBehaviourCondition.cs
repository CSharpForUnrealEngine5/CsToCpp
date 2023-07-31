#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct representing a single Condition</summary>
[CppInclude("Behaviour/Builtin/Conditional/RCBehaviourConditional.h")]
public partial struct FRCBehaviourCondition {
	public ERCBehaviourConditionType ConditionType;
	public URCVirtualPropertySelfContainer Comparand;
}
