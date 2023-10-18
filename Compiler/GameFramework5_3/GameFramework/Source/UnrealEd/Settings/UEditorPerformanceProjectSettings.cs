namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configure per-project performance settings for the Editor</summary>
[CppInclude("Settings/EditorProjectSettings.h")]
public partial class UEditorPerformanceProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>RealtimeScreenPercentageMode</summary>
	public EScreenPercentageMode RealtimeScreenPercentageMode;
	///<summary>MobileScreenPercentageMode</summary>
	public EScreenPercentageMode MobileScreenPercentageMode;
	///<summary>VRScreenPercentageMode</summary>
	public EScreenPercentageMode VRScreenPercentageMode;
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
