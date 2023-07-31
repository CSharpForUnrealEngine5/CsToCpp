#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Enumeration of policies for dealing with duration of a gameplay effect while stacking</summary>
public enum EGameplayEffectStackingDurationPolicy {
	RefreshOnSuccessfulApplication=0,
	NeverRefresh=1,
}
