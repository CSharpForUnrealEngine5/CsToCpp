namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to store spectral data with time-stamps</summary>
[CppInclude("Sound/SoundWave.h")]
public partial struct FSoundWaveSpectralTimeData {
	public TArray<FSoundWaveSpectralDataEntry> Data;
	public float TimeSec;
}
