#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GerstnerWaterWaves.h")]
public partial class UGerstnerWaterWaves : UWaterWaves {
// GerstnerWaterWaves
	public UGerstnerWaterWaveGeneratorBase GerstnerWaveGenerator;
	public TArray<FGerstnerWave> GerstnerWaves;
	public float MaxWaveHeight;
}
