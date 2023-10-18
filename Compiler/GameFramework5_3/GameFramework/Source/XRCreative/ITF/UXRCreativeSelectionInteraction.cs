namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ITF/SelectionInteraction.h")]
public partial class UXRCreativeSelectionInteraction : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>click-to-select behavior</summary>
	public USingleClickInputBehavior ClickBehavior;
	///<summary>set of all behaviors, will be passed up to UInputRouter</summary>
	public UInputBehaviorSet BehaviorSet;
}
