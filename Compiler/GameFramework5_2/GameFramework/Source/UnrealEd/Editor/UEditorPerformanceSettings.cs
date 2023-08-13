namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings to tweak the performance of the editor</summary>
[CppInclude("Editor/EditorPerformanceSettings.h")]
public partial class UEditorPerformanceSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>When enabled, the application frame rate, memory and Unreal object count will be displayed in the main editor UI</summary>
	public bool bShowFrameRateAndMemory;
	///<summary>Lowers CPU usage when the editor is in the background and not the active application</summary>
	public bool bThrottleCPUWhenNotForeground;
	///<summary>Disables realtime viewports by default when connected via a remote session</summary>
	public bool bDisableRealtimeViewportsInRemoteSessions;
	///<summary>When turned on, the editor will constantly monitor performance and adjust scalability settings for you when performance drops (disabled in debug)</summary>
	public bool bMonitorEditorPerformance;
	///<summary>When enabled, a warning will appear in the viewport when your editors scalability settings are non-default and you may be viewing a low quality scene</summary>
	public bool bEnableScalabilityWarningIndicator;
	///<summary>By default the editor will adjust scene scaling (quality) for high DPI in order to ensure consistent performance with very large render targets.</summary>
	public bool bDisplayHighDPIViewports;
	///<summary>bOverridePIEScreenPercentage</summary>
	public bool bOverridePIEScreenPercentage;
	///<summary>RealtimeScreenPercentageMode</summary>
	public EEditorUserScreenPercentageModeOverride RealtimeScreenPercentageMode;
	///<summary>PathTracerScreenPercentageMode</summary>
	public EEditorUserScreenPercentageModeOverride PathTracerScreenPercentageMode;
	///<summary>NonRealtimeScreenPercentageMode</summary>
	public EEditorUserScreenPercentageModeOverride NonRealtimeScreenPercentageMode;
	///<summary>bOverrideManualScreenPercentage</summary>
	public bool bOverrideManualScreenPercentage;
	///<summary>Editor viewport screen percentage</summary>
	public float ManualScreenPercentage;
	///<summary>bOverrideMinViewportRenderingResolution</summary>
	public bool bOverrideMinViewportRenderingResolution;
	///<summary>MinViewportRenderingResolution</summary>
	public int MinViewportRenderingResolution;
	///<summary>bOverrideMaxViewportRenderingResolution</summary>
	public bool bOverrideMaxViewportRenderingResolution;
	///<summary>MaxViewportRenderingResolution</summary>
	public int MaxViewportRenderingResolution;
}
