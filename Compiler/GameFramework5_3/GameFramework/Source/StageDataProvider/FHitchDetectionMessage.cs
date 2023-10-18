namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message sent when a hitch was detected on a provider machine.</summary>
[CppInclude("FramePerformanceProvider.h")]
public partial struct FHitchDetectionMessage {
	public float GameThreadWithWaitsMS;
	public float RenderThreadWithWaitsMS;
	public float GameThreadMS;
	public float RenderThreadMS;
	public float GPU_MS;
	public float TimingThreshold;
	public float HitchedTimeFPS;
	public float AverageFPS;
}
