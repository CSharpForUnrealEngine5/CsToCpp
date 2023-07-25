#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Enumeration of policies for dealing with the period of a gameplay effect while stacking</summary>
public enum EGameplayEffectStackingPeriodPolicy {
	ResetOnSuccessfulApplication=0,
	NeverReset=1,
}
