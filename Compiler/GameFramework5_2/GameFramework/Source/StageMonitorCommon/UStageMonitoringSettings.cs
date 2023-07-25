#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageMonitoringSettings.h")]
///<summary>Settings for the StageMonitoring plugin modules.</summary>
public partial class UStageMonitoringSettings : UDeveloperSettings {
// StageMonitoringSettings
	public bool bUseSessionId;
	public int StageSessionId;
	public float TimeoutInterval;
	public FStageMonitorSettings MonitorSettings;
	public FStageDataProviderSettings ProviderSettings;
	public FStageDataExportSettings ExportSettings;
}
