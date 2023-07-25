#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActiveGameplayEffectHandle.h")]
///<summary>This handle is required for things outside of FActiveGameplayEffectsContainer to refer to a specific active GameplayEffect</summary>
public partial struct FActiveGameplayEffectHandle {
// ActiveGameplayEffectHandle
	public int Handle;
	public bool bPassedFiltersAndWasExecuted;
}
