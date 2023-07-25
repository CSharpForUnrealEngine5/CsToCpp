#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Behaviour/Builtin/Conditional/RCBehaviourConditional.h")]
///<summary>[Conditional Behaviour]</summary>
public partial class URCBehaviourConditional : URCBehaviour {
// RCBehaviourConditional
	public TMap<URCAction,FRCBehaviourCondition> Conditions;
	public URCVirtualPropertySelfContainer Comparand;
}
