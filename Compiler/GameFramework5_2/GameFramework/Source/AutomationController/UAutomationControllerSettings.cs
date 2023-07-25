#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationControllerSettings.h")]
///<summary>Implements the Editor's user settings.</summary>
public partial class UAutomationControllerSettings : UObject {
// AutomationControllerSettings
	public TArray<FAutomatedTestGroup> Groups;
	public bool bSuppressLogErrors;
	public bool bSuppressLogWarnings;
	public bool bElevateLogWarningsToErrors;
	public TArray<string> SuppressedLogCategories;
	public bool bKeepPIEOpen;
	public bool bTreatLogWarningsAsTestErrors;
	public float CheckTestIntervalSeconds;
	public float GameInstanceLostTimerSeconds;
	public string TelemetryDirectory;
	public bool bResetTelemetryStorageOnNewSession;
}
