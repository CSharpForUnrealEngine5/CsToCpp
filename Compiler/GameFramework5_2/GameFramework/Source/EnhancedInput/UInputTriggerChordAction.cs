#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInputTriggerChordAction</summary>
[CppInclude("InputTriggers.h")]
public partial class UInputTriggerChordAction : UInputTrigger {
	public static UClass StaticClass() {return default;}
	///<summary>The action that must be triggering for this trigger&#39;s action to trigger</summary>
	public UInputAction ChordAction;
}
