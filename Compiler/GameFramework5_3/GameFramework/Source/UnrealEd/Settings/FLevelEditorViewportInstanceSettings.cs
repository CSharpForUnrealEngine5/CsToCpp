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
	public FName BufferVisualizationMode;
	public FName NaniteVisualizationMode;
	public FName LumenVisualizationMode;
	public FName StrataVisualizationMode;
	public FName GroomVisualizationMode;
	public FName VirtualShadowMapVisualizationMode;
	public FName RayTracingDebugVisualizationMode;
	public FName GPUSkinCacheVisualizationMode;
	public FExposureSettings ExposureSettings;
	public float FOVAngle;
	public float FarViewPlane;
	public bool bIsRealtime;
	public bool bShowFPS_DEPRECATED;
	public bool bShowOnScreenStats;
	public TArray<string> EnabledStats;
	public bool bShowFullToolbar;
}
