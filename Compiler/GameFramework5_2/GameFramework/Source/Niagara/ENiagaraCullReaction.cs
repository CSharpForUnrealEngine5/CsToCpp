#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEffectType.h")]
///<summary>Controls what action is taken by a Niagara system that fails it&#39;s cull checks.</summary>
public enum ENiagaraCullReaction {
	Deactivate=0,
	DeactivateImmediate=1,
	DeactivateResume=2,
	DeactivateImmediateResume=3,
}
