namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerConfig.h")]
public partial struct FGameplayDebuggerCategoryConfig {
	public string CategoryName;
	public int SlotIdx;
	public EGameplayDebuggerOverrideMode ActiveInGame;
	public EGameplayDebuggerOverrideMode ActiveInSimulate;
	public EGameplayDebuggerOverrideMode Hidden;
	public bool bOverrideSlotIdx;
	public TArray<FGameplayDebuggerInputConfig> InputHandlers;
}
