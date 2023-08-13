namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioCaptureComponent.h")]
public partial class UAudioCaptureComponent : USynthComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Induced latency in audio frames to use to account for jitter between mic capture hardware and audio render hardware.</summary>
	public int JitterLatencyFrames;
}
