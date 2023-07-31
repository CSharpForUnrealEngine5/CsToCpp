#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base for specialized gameplay effect calculations; Capable of specifing attribute captures</summary>
[CppInclude("GameplayEffectCalculation.h")]
public partial class UGameplayEffectCalculation : UObject {
	///<summary>Attributes to capture that are relevant to the calculation</summary>
	public TArray<FGameplayEffectAttributeCaptureDefinition> RelevantAttributesToCapture;
}
