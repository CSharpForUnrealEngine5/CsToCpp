namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>The version of the UGameplayEffect. Used for upgrade paths.</summary>
public enum EGameplayEffectVersion {
	Monolithic=0,
	Modular53=1,
	AbilitiesComponent53=2,
	Current=-1,
}
