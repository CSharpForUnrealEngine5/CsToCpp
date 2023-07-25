#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/EditorPerformanceSettings.h")]
///<summary>Settings to tweak the performance of the editor</summary>
public partial class UEditorPerformanceSettings : UDeveloperSettings {
// EditorPerformanceSettings
	public bool bShowFrameRateAndMemory;
	public bool bThrottleCPUWhenNotForeground;
	public bool bDisableRealtimeViewportsInRemoteSessions;
	public bool bMonitorEditorPerformance;
	public bool bEnableScalabilityWarningIndicator;
	public bool bDisplayHighDPIViewports;
	public bool bOverridePIEScreenPercentage;
	public EEditorUserScreenPercentageModeOverride RealtimeScreenPercentageMode;
	public EEditorUserScreenPercentageModeOverride PathTracerScreenPercentageMode;
	public EEditorUserScreenPercentageModeOverride NonRealtimeScreenPercentageMode;
	public bool bOverrideManualScreenPercentage;
	public float ManualScreenPercentage;
	public bool bOverrideMinViewportRenderingResolution;
	public int MinViewportRenderingResolution;
	public bool bOverrideMaxViewportRenderingResolution;
	public int MaxViewportRenderingResolution;
}
