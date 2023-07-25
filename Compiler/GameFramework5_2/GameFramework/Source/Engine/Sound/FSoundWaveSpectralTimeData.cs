#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundWave.h")]
///<summary>Struct used to store spectral data with time-stamps</summary>
public partial struct FSoundWaveSpectralTimeData {
// SoundWaveSpectralTimeData
	public TArray<FSoundWaveSpectralDataEntry> Data;
	public float TimeSec;
}
