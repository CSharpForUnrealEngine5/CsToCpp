#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectAttributeCaptureDefinition.h")]
///<summary>Struct defining gameplay attribute capture options for gameplay effects</summary>
public partial struct FGameplayEffectAttributeCaptureDefinition {
// GameplayEffectAttributeCaptureDefinition
	public FGameplayAttribute AttributeToCapture;
	public EGameplayEffectAttributeCaptureSource AttributeSource;
	public bool bSnapshot;
}
