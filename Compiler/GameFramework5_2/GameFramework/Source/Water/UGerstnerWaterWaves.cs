#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GerstnerWaterWaves.h")]
public partial class UGerstnerWaterWaves : UWaterWaves {
	///<summary>GerstnerWaveGenerator</summary>
	public UGerstnerWaterWaveGeneratorBase GerstnerWaveGenerator;
	///<summary>GerstnerWaves</summary>
	public TArray<FGerstnerWave> GerstnerWaves;
	///<summary>MaxWaveHeight</summary>
	public float MaxWaveHeight;
}
