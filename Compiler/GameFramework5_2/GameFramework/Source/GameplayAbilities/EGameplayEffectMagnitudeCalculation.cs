#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffect.h")]
///<summary>Enumeration outlining the possible gameplay effect magnitude calculation policies.</summary>
public enum EGameplayEffectMagnitudeCalculation {
	ScalableFloat=0,
	AttributeBased=1,
	CustomCalculationClass=2,
	SetByCaller=3,
}
