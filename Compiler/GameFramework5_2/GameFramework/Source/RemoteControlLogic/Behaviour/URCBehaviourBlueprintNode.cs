namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base blueprint class for behaviour node which holds the logic to execute behaviour</summary>
[CppInclude("Behaviour/RCBehaviourBlueprintNode.h")]
public partial class URCBehaviourBlueprintNode : URCBehaviourNode {
	public static UClass StaticClass() {return default;}
	///<summary>IsSupported</summary>
	public bool IsSupported(URCBehaviour InBehaviour) { return default; }
	///<summary>Execute</summary>
	public bool Execute(URCBehaviour InBehaviour) { return default; }
	///<summary>PreExecute</summary>
	public void PreExecute(URCBehaviour InBehaviour) {}
	///<summary>OnPassed</summary>
	public void OnPassed(URCBehaviour InBehaviour) {}
}
