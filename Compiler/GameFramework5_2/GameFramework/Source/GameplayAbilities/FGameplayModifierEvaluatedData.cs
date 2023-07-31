#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data that describes what happened in an attribute modification. This is passed to ability set callbacks</summary>
[CppInclude("GameplayEffectTypes.h")]
public partial struct FGameplayModifierEvaluatedData {
	public FGameplayAttribute Attribute;
	public EGameplayModOp ModifierOp;
	public float Magnitude;
	public FActiveGameplayEffectHandle Handle;
	public bool IsValid;
}
