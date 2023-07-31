#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to hold the result of a gameplay attribute capture; Initially seeded by definition data, but then populated by ability system component when appropriate</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FGameplayEffectAttributeCaptureSpec {
	public FGameplayEffectAttributeCaptureDefinition BackingDefinition;
}
