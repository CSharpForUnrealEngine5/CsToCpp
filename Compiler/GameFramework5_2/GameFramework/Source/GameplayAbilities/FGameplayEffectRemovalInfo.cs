#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data struct for containing information pertinent to GameplayEffects as they are removed</summary>
[CppInclude("GameplayEffectTypes.h")]
public partial struct FGameplayEffectRemovalInfo {
	public bool bPrematureRemoval;
	public int StackCount;
	public FGameplayEffectContextHandle EffectContext;
}
