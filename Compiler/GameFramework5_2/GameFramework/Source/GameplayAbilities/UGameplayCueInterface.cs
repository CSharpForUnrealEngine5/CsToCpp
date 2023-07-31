#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueInterface.h")]
public partial class UGameplayCueInterface : UInterface {
	///<summary>Internal function to map ufunctions directly to gameplaycue tags</summary>
	public  void BlueprintCustomHandler(EGameplayCueEvent EventType,FGameplayCueParameters Parameters) {}
	///<summary>Call from a Cue handler event to continue checking for additional, more generic handlers. Called from the ability system blueprint library</summary>
	public  void ForwardGameplayCueToParent() {}
}
