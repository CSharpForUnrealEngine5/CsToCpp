namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This handle is required for things outside of FActiveGameplayEffectsContainer to refer to a specific active GameplayEffect</summary>
[CppInclude("ActiveGameplayEffectHandle.h")]
public partial struct FActiveGameplayEffectHandle {
	public int Handle;
	public bool bPassedFiltersAndWasExecuted;
}
