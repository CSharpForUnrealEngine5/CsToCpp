#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Update manager</summary>
[CppInclude("UpdateManager.h")]
public partial class UUpdateManager : UObject {
	///<summary>Amount of time to wait between the internal hotfix check completing and advancing to the next stage</summary>
	public float HotfixCheckCompleteDelay;
	///<summary>Amount of time to wait at the end of the entire check before notifying listening entities</summary>
	public float UpdateCheckCompleteDelay;
	///<summary>Amount of time to wait between the internal hotfix availability check completing and advancing to the next stage</summary>
	public float HotfixAvailabilityCheckCompleteDelay;
	///<summary>Amount of time to wait at the end of the entire check before notifying listening entities (availability check only)</summary>
	public float UpdateCheckAvailabilityCompleteDelay;
	///<summary>If application is suspended longer than this, trigger an update check when resuming</summary>
	public int AppSuspendedUpdateCheckTimeSeconds;
	///<summary>true if we&#39;ve already detected the backend environment</summary>
	public bool bPlatformEnvironmentDetected;
	///<summary>Has the first update completed</summary>
	public bool bInitialUpdateFinished;
	///<summary>Is this run only checking and not applying</summary>
	public bool bCheckHotfixAvailabilityOnly;
	///<summary>Current state of the update</summary>
	public EUpdateState CurrentUpdateState;
	///<summary>What was the maximum number of pending async loads we&#39;ve seen so far</summary>
	public int WorstNumFilesPendingLoadViewed;
	///<summary>Result of the last hotfix</summary>
	public EHotfixResult LastHotfixResult;
	///<summary>Timestamp of last update check (0:normal, 1:availability only)</summary>
	public FDateTime LastUpdateCheck;
	///<summary>Last update check result (0:normal, 1:availability only)</summary>
	public EUpdateCompletionStatus LastCompletionResult;
	///<summary>String output</summary>
	public UEnum UpdateStateEnum;
	///<summary>UpdateCompletionEnum</summary>
	public UEnum UpdateCompletionEnum;
	///<summary>Definition to use when a context lookup fails.</summary>
	public FUpdateContextDefinition UpdateContextDefinitionUnknown;
	///<summary>Definitions for update behavior.</summary>
	public TArray<FUpdateContextDefinition> UpdateContextDefinitions;
}
