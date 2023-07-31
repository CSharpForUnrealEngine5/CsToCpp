#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings associated to file exporter</summary>
[CppInclude("StageMonitoringSettings.h")]
public partial struct FStageDataExportSettings {
	public bool bKeepOnlyLastPeriodMessage;
	public TArray<FStageMessageTypeWrapper> ExcludedMessageTypes;
}
