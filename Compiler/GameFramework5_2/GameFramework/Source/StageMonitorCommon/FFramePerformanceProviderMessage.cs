#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageMonitorUtils.h")]
///<summary>Message containing information about frame timings.</summary>
public partial struct FFramePerformanceProviderMessage {
// FramePerformanceProviderMessage
	public EStageMonitorNodeStatus Status;
	public string AssetInStatus;
	public float AverageFPS;
	public float GameThreadMS;
	public float RenderThreadMS;
	public float GPU_MS;
	public float IdleTimeMS;
	public int ShadersToCompile;
}
