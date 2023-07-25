#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGridUtils.h")]
///<summary>This struct keeps track of the values of the GEngine framerate settings before new values were applied, so we can rollback to the previous state.</summary>
public partial struct FRenderGridPreviousEngineFpsSettings {
// RenderGridPreviousEngineFpsSettings
	public bool bHasBeenSet;
	public bool bUseFixedFrameRate;
	public bool bForceDisableFrameRateSmoothing;
	public float MaxFps;
	public bool bVSync;
	public bool bVSyncEditor;
	public bool bThrottleCPUWhenNotForeground;
}
