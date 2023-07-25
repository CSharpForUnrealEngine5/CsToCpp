#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectTypes.h")]
///<summary>Data struct for containing information pertinent to GameplayEffects as they are removed</summary>
public partial struct FGameplayEffectRemovalInfo {
// GameplayEffectRemovalInfo
	public bool bPrematureRemoval;
	public int StackCount;
	public FGameplayEffectContextHandle EffectContext;
}
