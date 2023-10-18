namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GerstnerWaterWaves.h")]
public partial class UGerstnerWaterWaves : UWaterWaves {
	public static UClass StaticClass() {return default;}
	///<summary>GerstnerWaveGenerator</summary>
	public UGerstnerWaterWaveGeneratorBase GerstnerWaveGenerator;
	///<summary>GerstnerWaves</summary>
	public TArray<FGerstnerWave> GerstnerWaves;
	///<summary>MaxWaveHeight</summary>
	public float MaxWaveHeight;
}
