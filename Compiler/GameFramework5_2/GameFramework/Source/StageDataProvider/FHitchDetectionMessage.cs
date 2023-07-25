#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FramePerformanceProvider.h")]
///<summary>Message sent when a hitch was detected on a provider machine.</summary>
public partial struct FHitchDetectionMessage {
// HitchDetectionMessage
	public float GameThreadWithWaitsMS;
	public float RenderThreadWithWaitsMS;
	public float GameThreadMS;
	public float RenderThreadMS;
	public float GPU_MS;
	public float TimingThreshold;
	public float HitchedTimeFPS;
	public float AverageFPS;
}
