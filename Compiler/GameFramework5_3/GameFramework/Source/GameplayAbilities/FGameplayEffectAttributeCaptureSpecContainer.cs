namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to handle a collection of captured source and target attributes</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FGameplayEffectAttributeCaptureSpecContainer {
	public TArray<FGameplayEffectAttributeCaptureSpec> SourceAttributes;
	public TArray<FGameplayEffectAttributeCaptureSpec> TargetAttributes;
	public bool bHasNonSnapshottedAttributes;
}
