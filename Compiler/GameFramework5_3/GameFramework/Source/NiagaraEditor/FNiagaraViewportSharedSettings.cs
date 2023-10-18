namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains all the settings that should be shared across sessions.</summary>
[CppInclude("NiagaraEditorSettings.h")]
public partial struct FNiagaraViewportSharedSettings {
	public ELevelViewportType ViewportType;
	public EViewModeIndex PerspViewModeIndex;
	public EViewModeIndex OrthoViewModeIndex;
	public string EditorShowFlagsString;
	public string GameShowFlagsString;
	public FExposureSettings ExposureSettings;
	public float FOVAngle;
	public bool bIsRealtime;
	public bool bShowOnScreenStats;
	public bool bShowGridInViewport;
	public bool bShowInstructionsCount;
	public bool bShowParticleCountsInViewport;
	public bool bShowEmitterExecutionOrder;
	public bool bShowGpuTickInformation;
	public bool bShowMemoryInfo;
}
