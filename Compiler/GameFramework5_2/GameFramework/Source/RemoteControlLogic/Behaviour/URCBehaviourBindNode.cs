#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Behaviour Node class for Bind Behaviour</summary>
[CppInclude("Behaviour/Builtin/Bind/RCBehaviourBindNode.h")]
public partial class URCBehaviourBindNode : URCBehaviourNode {
	public static UClass StaticClass() {return default;}
	///<summary>Execute</summary>
	public  bool Execute(URCBehaviour InBehaviour) { return default; }
	///<summary>IsSupported</summary>
	public  bool IsSupported(URCBehaviour InBehaviour) { return default; }
	///<summary>OnPassed</summary>
	public  void OnPassed(URCBehaviour InBehaviour) {}
}
