#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedPlayerInput.h")]
///<summary>UEnhancedPlayerInput : UPlayerInput extensions for enhanced player input system</summary>
public partial class UEnhancedPlayerInput : UPlayerInput {
// EnhancedPlayerInput
	public TMap<UInputMappingContext,int> AppliedInputContexts;
	public TArray<FEnhancedActionKeyMapping> EnhancedActionMappings;
	public TMap<UInputAction,FInputActionInstance> ActionInstanceData;
	public TMap<FKey,FVector> KeysPressedThisTick;
	public TMap<UInputAction,FInjectedInputArray> InputsInjectedThisTick;
	public TSet<UInputAction> LastInjectedActions;
}
