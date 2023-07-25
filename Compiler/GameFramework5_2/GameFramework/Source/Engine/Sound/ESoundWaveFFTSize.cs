#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundWave.h")]
///<summary>The FFT size (in audio frames) to use for baked FFT analysis</summary>
public enum ESoundWaveFFTSize {
	VerySmall_64=0,
	Small_256=1,
	Medium_512=2,
	Large_1024=3,
	VeryLarge_2048=4,
}
