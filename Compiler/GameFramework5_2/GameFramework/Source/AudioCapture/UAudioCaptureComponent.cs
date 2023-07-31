#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioCaptureComponent.h")]
public partial class UAudioCaptureComponent : USynthComponent {
	///<summary>Induced latency in audio frames to use to account for jitter between mic capture hardware and audio render hardware.</summary>
	public int JitterLatencyFrames;
}
