namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for behaviour node which holds the logic to execute behaviour</summary>
[CppInclude("Behaviour/RCBehaviourNode.h")]
public partial class URCBehaviourNode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>User-friendly display name for this Behavior, displayed in Action Panel&#39;s Header.</summary>
	public FText DisplayName;
	///<summary>Detailed description of what this behavior does, displayed in Action Panel&#39;s Header.</summary>
	public FText BehaviorDescription;
}
