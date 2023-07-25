#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageMonitoringSettings.h")]
///<summary>Settings associated to file exporter</summary>
public partial struct FStageDataExportSettings {
// StageDataExportSettings
	public bool bKeepOnlyLastPeriodMessage;
	public TArray<FStageMessageTypeWrapper> ExcludedMessageTypes;
}
