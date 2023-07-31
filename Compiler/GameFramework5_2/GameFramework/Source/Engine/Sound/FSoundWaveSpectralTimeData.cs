#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to store spectral data with time-stamps</summary>
[CppInclude("Sound/SoundWave.h")]
public partial struct FSoundWaveSpectralTimeData {
	public TArray<FSoundWaveSpectralDataEntry> Data;
	public float TimeSec;
}
