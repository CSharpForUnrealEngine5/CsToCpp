#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UpdateManager.h")]
///<summary>Update manager</summary>
public partial class UUpdateManager : UObject {
// UpdateManager
	public float HotfixCheckCompleteDelay;
	public float UpdateCheckCompleteDelay;
	public float HotfixAvailabilityCheckCompleteDelay;
	public float UpdateCheckAvailabilityCompleteDelay;
	public int AppSuspendedUpdateCheckTimeSeconds;
	public bool bPlatformEnvironmentDetected;
	public bool bInitialUpdateFinished;
	public bool bCheckHotfixAvailabilityOnly;
	public EUpdateState CurrentUpdateState;
	public int WorstNumFilesPendingLoadViewed;
	public EHotfixResult LastHotfixResult;
	public FDateTime LastUpdateCheck;
	public EUpdateCompletionStatus LastCompletionResult;
	public UEnum UpdateStateEnum;
	public UEnum UpdateCompletionEnum;
	public FUpdateContextDefinition UpdateContextDefinitionUnknown;
	public TArray<FUpdateContextDefinition> UpdateContextDefinitions;
}
