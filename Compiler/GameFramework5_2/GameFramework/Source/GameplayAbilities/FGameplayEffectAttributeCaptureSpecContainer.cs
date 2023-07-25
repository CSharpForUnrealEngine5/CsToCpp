#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Struct used to handle a collection of captured source and target attributes</summary>
public partial struct FGameplayEffectAttributeCaptureSpecContainer {
// GameplayEffectAttributeCaptureSpecContainer
	public TArray<FGameplayEffectAttributeCaptureSpec> SourceAttributes;
	public TArray<FGameplayEffectAttributeCaptureSpec> TargetAttributes;
	public bool bHasNonSnapshottedAttributes;
}
