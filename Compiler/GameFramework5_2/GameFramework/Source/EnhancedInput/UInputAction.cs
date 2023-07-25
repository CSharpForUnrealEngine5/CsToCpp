#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputAction.h")]
///<summary>Input action definition. These are instanced per player (via FInputActionInstance)</summary>
public partial class UInputAction : UDataAsset {
// InputAction
	public string ActionDescription;
	public bool bConsumeInput;
	public bool bTriggerWhenPaused;
	public bool bReserveAllMappings;
	public EInputActionValueType ValueType;
	public TArray<UInputTrigger> Triggers;
	public TArray<UInputModifier> Modifiers;
	public UPlayerMappableKeySettings PlayerMappableKeySettings;
}
