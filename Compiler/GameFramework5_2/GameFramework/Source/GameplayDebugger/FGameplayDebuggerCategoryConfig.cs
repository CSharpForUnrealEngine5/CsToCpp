#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerConfig.h")]
public partial struct FGameplayDebuggerCategoryConfig {
// GameplayDebuggerCategoryConfig
	public string CategoryName;
	public int SlotIdx;
	public EGameplayDebuggerOverrideMode ActiveInGame;
	public EGameplayDebuggerOverrideMode ActiveInSimulate;
	public EGameplayDebuggerOverrideMode Hidden;
	public bool bOverrideSlotIdx;
	public TArray<FGameplayDebuggerInputConfig> InputHandlers;
}
