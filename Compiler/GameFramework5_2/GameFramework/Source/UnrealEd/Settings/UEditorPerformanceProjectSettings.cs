#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorProjectSettings.h")]
///<summary>Configure per-project performance settings for the Editor</summary>
public partial class UEditorPerformanceProjectSettings : UDeveloperSettings {
// EditorPerformanceProjectSettings
	public EScreenPercentageMode RealtimeScreenPercentageMode;
	public EScreenPercentageMode PathTracerScreenPercentageMode;
	public EScreenPercentageMode NonRealtimeScreenPercentageMode;
	public float ManualScreenPercentage;
	public int MinViewportRenderingResolution;
	public int MaxViewportRenderingResolution;
}
