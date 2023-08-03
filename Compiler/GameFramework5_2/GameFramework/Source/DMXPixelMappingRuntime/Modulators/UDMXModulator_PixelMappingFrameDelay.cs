#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Delays the incoming singal by number of Delay Frames. Only useful for PixelMapping and constant frame rates.</summary>
[CppInclude("Modulators/DMXModulator_PixelMappingFrameDelay.h")]
public partial class UDMXModulator_PixelMappingFrameDelay : UDMXModulator {
	public static UClass StaticClass() {return default;}
	///<summary>The time by which signals are delayed in Seconds</summary>
	public int DelayFrames;
}
