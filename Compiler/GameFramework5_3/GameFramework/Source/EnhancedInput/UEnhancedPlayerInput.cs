namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UEnhancedPlayerInput : UPlayerInput extensions for enhanced player input system</summary>
[CppInclude("EnhancedPlayerInput.h")]
public partial class UEnhancedPlayerInput : UPlayerInput {
	public static UClass StaticClass() {return default;}
	///<summary>Array of data that represents what keys should be consumed if an enhanced input action is in a specific triggered state</summary>
	public TMap<UInputAction,FKeyConsumptionOptions> KeyConsumptionData;
	///<summary>Currently applied key mappings</summary>
	public TMap<UInputMappingContext,int> AppliedInputContexts;
	///<summary>This player&#39;s version of the Action Mappings</summary>
	public TArray<FEnhancedActionKeyMapping> EnhancedActionMappings;
	///<summary>Tracked action values. Queryable.</summary>
	public TMap<UInputAction,FInputActionInstance> ActionInstanceData;
	///<summary>A map of Keys to the amount they were depressed this frame. This is reset with each call to ProcessInputStack</summary>
	public TMap<FKey,FVector> KeysPressedThisTick;
	///<summary>Inputs injected since the last call to ProcessInputStack</summary>
	public TMap<UInputAction,FInjectedInputArray> InputsInjectedThisTick;
	///<summary>Last frame&#39;s injected inputs</summary>
	public TSet<UInputAction> LastInjectedActions;
}
