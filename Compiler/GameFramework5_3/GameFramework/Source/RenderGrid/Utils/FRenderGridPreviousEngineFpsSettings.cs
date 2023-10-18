namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct keeps track of the values of the GEngine framerate settings before new values were applied, so we can rollback to the previous state.</summary>
[CppInclude("Utils/RenderGridUtils.h")]
public partial struct FRenderGridPreviousEngineFpsSettings {
	public bool bHasBeenSet;
	public bool bUseFixedFrameRate;
	public bool bForceDisableFrameRateSmoothing;
	public float MaxFps;
	public bool bVSync;
	public bool bVSyncEditor;
	public bool bThrottleCPUWhenNotForeground;
}
