#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base blueprint class for behaviour node which holds the logic to execute behaviour</summary>
[CppInclude("Behaviour/RCBehaviourBlueprintNode.h")]
public partial class URCBehaviourBlueprintNode : URCBehaviourNode {
	///<summary>IsSupported</summary>
	public  bool IsSupported(URCBehaviour InBehaviour) { return default; }
	///<summary>Execute</summary>
	public  bool Execute(URCBehaviour InBehaviour) { return default; }
	///<summary>PreExecute</summary>
	public  void PreExecute(URCBehaviour InBehaviour) {}
	///<summary>OnPassed</summary>
	public  void OnPassed(URCBehaviour InBehaviour) {}
}
