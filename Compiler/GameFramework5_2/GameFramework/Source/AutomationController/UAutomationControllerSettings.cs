#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Editor&#39;s user settings.</summary>
[CppInclude("AutomationControllerSettings.h")]
public partial class UAutomationControllerSettings : UObject {
	///<summary>List of user-defined test groups</summary>
	public TArray<FAutomatedTestGroup> Groups;
	///<summary>Whether to suppress log from test results (default=false)</summary>
	public bool bSuppressLogErrors;
	///<summary>Whether to suppress log warnings from test results (default=false)</summary>
	public bool bSuppressLogWarnings;
	///<summary>Whether to treat log warnings as log errors (default=true)</summary>
	public bool bElevateLogWarningsToErrors;
	///<summary>Log categories where warnings/errors will not affect the result of tests. A finer-grained way of preventing rogue systems from leading to test warnings/errors</summary>
	public TArray<string> SuppressedLogCategories;
	///<summary>Whether to keep the PIE Open in the editor at the end of a test pass (default=false)</summary>
	public bool bKeepPIEOpen;
	///<summary>Whether to treat log warnings as test errors (default=true)</summary>
	public bool bTreatLogWarningsAsTestErrors;
	///<summary>How long to wait between test updates (default=1sec)</summary>
	public float CheckTestIntervalSeconds;
	///<summary>The maximum response wait time for detecting a lost game instance (default=300sec)</summary>
	public float GameInstanceLostTimerSeconds;
	///<summary>Path to where telemetry files are saved (default=&lt;project&gt;/Saved/Automation/Telemetry/)</summary>
	public string TelemetryDirectory;
	///<summary>Whether to reset data stored in telemetry file (default=false)</summary>
	public bool bResetTelemetryStorageOnNewSession;
}
