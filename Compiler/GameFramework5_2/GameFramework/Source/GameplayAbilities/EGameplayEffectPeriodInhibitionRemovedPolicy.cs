#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Enumeration of policies for dealing with the period of a gameplay effect when inhibition is removed</summary>
public enum EGameplayEffectPeriodInhibitionRemovedPolicy {
	NeverReset=0,
	ResetPeriod=1,
	ExecuteAndResetPeriod=2,
}
