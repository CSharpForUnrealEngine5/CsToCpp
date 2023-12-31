namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Saves list of modified attributes, to use for gameplay cues or later processing</summary>
[CppInclude("GameplayEffect.h")]
public partial struct FGameplayEffectModifiedAttribute {
	public FGameplayAttribute Attribute;
	public float TotalMagnitude;
}
