#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectCalculation.h")]
///<summary>Abstract base for specialized gameplay effect calculations; Capable of specifing attribute captures</summary>
public partial class UGameplayEffectCalculation : UObject {
// GameplayEffectCalculation
	public TArray<FGameplayEffectAttributeCaptureDefinition> RelevantAttributesToCapture;
}
