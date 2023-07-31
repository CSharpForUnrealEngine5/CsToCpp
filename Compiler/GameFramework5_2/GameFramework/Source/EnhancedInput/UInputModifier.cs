#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for building modifiers.</summary>
[CppInclude("InputModifiers.h")]
public partial class UInputModifier : UObject {
	///<summary>ModifyRaw</summary>
	public  FInputActionValue ModifyRaw(UEnhancedPlayerInput PlayerInput,FInputActionValue CurrentValue,float DeltaTime) { return default; }
	///<summary>Helper to allow debug visualization of the modifier.</summary>
	public  FLinearColor GetVisualizationColor(FInputActionValue SampleValue,FInputActionValue FinalValue) { return default; }
}
