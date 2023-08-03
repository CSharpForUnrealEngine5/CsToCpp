#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the StageMonitoring plugin modules.</summary>
[CppInclude("StageMonitoringSettings.h")]
public partial class UStageMonitoringSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If true, Stage monitor will only listen to Stage Providers with same sessionId</summary>
	public bool bUseSessionId;
	///<summary>The projects Stage SessionId to differentiate data sent over network.</summary>
	public int StageSessionId;
	///<summary>Interval threshold between message reception before dropping out a provider or a monitor</summary>
	public float TimeoutInterval;
	///<summary>Settings for monitors</summary>
	public FStageMonitorSettings MonitorSettings;
	///<summary>Settings for Data Providers</summary>
	public FStageDataProviderSettings ProviderSettings;
	///<summary>Settings for Data Providers</summary>
	public FStageDataExportSettings ExportSettings;
}
