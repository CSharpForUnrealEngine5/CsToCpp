#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorViewportSettings.h")]
///<summary>Implements the Level Editor's per-instance view port settings.</summary>
public partial struct FLevelEditorViewportInstanceSettings {
// LevelEditorViewportInstanceSettings
	public byte ViewportType;
	public byte PerspViewModeIndex;
	public byte OrthoViewModeIndex;
	public string EditorShowFlagsString;
	public string GameShowFlagsString;
	public string BufferVisualizationMode;
	public string NaniteVisualizationMode;
	public string LumenVisualizationMode;
	public string StrataVisualizationMode;
	public string GroomVisualizationMode;
	public string VirtualShadowMapVisualizationMode;
	public string RayTracingDebugVisualizationMode;
	public string GPUSkinCacheVisualizationMode;
	public FExposureSettings ExposureSettings;
	public float FOVAngle;
	public float FarViewPlane;
	public bool bIsRealtime;
	public bool bShowFPS_DEPRECATED;
	public bool bShowOnScreenStats;
	public TArray<string> EnabledStats;
	public bool bShowFullToolbar;
}
