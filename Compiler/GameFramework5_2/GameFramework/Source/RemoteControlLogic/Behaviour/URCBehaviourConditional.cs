namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>[Conditional Behaviour]</summary>
[CppInclude("Behaviour/Builtin/Conditional/RCBehaviourConditional.h")]
public partial class URCBehaviourConditional : URCBehaviour {
	public static UClass StaticClass() {return default;}
	///<summary>Data storage for Actions and related Conditions; stored as a mapping of Action object and associated condition data</summary>
	public TMap<URCAction,FRCBehaviourCondition> Conditions;
	///<summary>Virtual property used to build the Comparand - i.e. the property with which the Controller will be compared for a given condition</summary>
	public URCVirtualPropertySelfContainer Comparand;
}
