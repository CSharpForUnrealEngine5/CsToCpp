#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputModifiers.h")]
///<summary>Base class for building modifiers.</summary>
public partial class UInputModifier : UObject {
// InputModifier
	public FInputActionValue ModifyRaw(UObject PlayerInput,FInputActionValue CurrentValue,float DeltaTime) { return default; }
	public FLinearColor GetVisualizationColor(FInputActionValue SampleValue,FInputActionValue FinalValue) { return default; }
}
