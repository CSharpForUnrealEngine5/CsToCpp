namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Enumeration of policies for dealing gameplay effect stacks that expire (in duration based effects).</summary>
public enum EGameplayEffectStackingExpirationPolicy {
	ClearEntireStack=0,
	RemoveSingleStackAndRefreshDuration=1,
	RefreshDuration=2,
}
