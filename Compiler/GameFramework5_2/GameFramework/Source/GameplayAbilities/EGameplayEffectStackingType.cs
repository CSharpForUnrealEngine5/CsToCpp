#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectTypes.h")]
///<summary>Enumeration for ways a single GameplayEffect asset can stack.</summary>
public enum EGameplayEffectStackingType {
	None=0,
	AggregateBySource=1,
	AggregateByTarget=2,
}
