#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayEffectTypes.h")]
///<summary>Defines the ways that mods will modify attributes. Numeric ones operate on the existing value, override ignores it</summary>
[CppEnumInNamespace]
public enum EGameplayModOp {
	Additive=0,
	Multiplicitive=1,
	Division=2,
	Override=3,
	Max=4,
}
