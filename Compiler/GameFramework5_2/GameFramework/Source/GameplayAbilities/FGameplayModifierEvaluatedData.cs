#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectTypes.h")]
///<summary>Data that describes what happened in an attribute modification. This is passed to ability set callbacks</summary>
public partial struct FGameplayModifierEvaluatedData {
// GameplayModifierEvaluatedData
	public FGameplayAttribute Attribute;
	public EGameplayModOp ModifierOp;
	public float Magnitude;
	public FActiveGameplayEffectHandle Handle;
	public bool IsValid;
}
