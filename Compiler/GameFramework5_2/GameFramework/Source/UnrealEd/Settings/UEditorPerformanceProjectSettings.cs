#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configure per-project performance settings for the Editor</summary>
[CppInclude("Settings/EditorProjectSettings.h")]
public partial class UEditorPerformanceProjectSettings : UDeveloperSettings {
	///<summary>RealtimeScreenPercentageMode</summary>
	public EScreenPercentageMode RealtimeScreenPercentageMode;
	///<summary>PathTracerScreenPercentageMode</summary>
	public EScreenPercentageMode PathTracerScreenPercentageMode;
	///<summary>NonRealtimeScreenPercentageMode</summary>
	public EScreenPercentageMode NonRealtimeScreenPercentageMode;
	///<summary>ManualScreenPercentage</summary>
	public float ManualScreenPercentage;
	///<summary>MinViewportRenderingResolution</summary>
	public int MinViewportRenderingResolution;
	///<summary>MaxViewportRenderingResolution</summary>
	public int MaxViewportRenderingResolution;
}
