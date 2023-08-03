#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Input action definition. These are instanced per player (via FInputActionInstance)</summary>
[CppInclude("InputAction.h")]
public partial class UInputAction : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>A localized descriptor of this input action</summary>
	public string ActionDescription;
	///<summary>Should this action swallow any inputs bound to it or allow them to pass through to affect lower priority bound actions?</summary>
	public bool bConsumeInput;
	///<summary>Should this action be able to trigger whilst the game is paused - Replaces bExecuteWhenPaused</summary>
	public bool bTriggerWhenPaused;
	///<summary>This action&#39;s mappings are not intended to be automatically overridden by higher priority context mappings. Users must explicitly remove the mapping first. NOTE: It is the responsibility of the author of the mapping code to enforce this!</summary>
	public bool bReserveAllMappings;
	///<summary>The type that this action returns from a GetActionValue query or action event</summary>
	public EInputActionValueType ValueType;
	///<summary>Trigger qualifiers. If any trigger qualifiers exist the action will not trigger unless:</summary>
	public TArray<UInputTrigger> Triggers;
	///<summary>Modifiers are applied to the final action value.</summary>
	public TArray<UInputModifier> Modifiers;
	///<summary>Holds setting information about this Action Input for setting screen and save purposes.</summary>
	public UPlayerMappableKeySettings PlayerMappableKeySettings;
}
