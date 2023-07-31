#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message containing information about frame timings.</summary>
[CppInclude("StageMonitorUtils.h")]
public partial struct FFramePerformanceProviderMessage {
	public EStageMonitorNodeStatus Status;
	public string AssetInStatus;
	public float AverageFPS;
	public float GameThreadMS;
	public float RenderThreadMS;
	public float GPU_MS;
	public float IdleTimeMS;
	public int ShadersToCompile;
}
