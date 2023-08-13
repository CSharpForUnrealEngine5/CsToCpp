namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Level Editor&#39;s per-instance view port settings.</summary>
[CppInclude("Settings/LevelEditorViewportSettings.h")]
public partial struct FLevelEditorViewportInstanceSettings {
	public ELevelViewportType ViewportType;
	public EViewModeIndex PerspViewModeIndex;
	public EViewModeIndex OrthoViewModeIndex;
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
