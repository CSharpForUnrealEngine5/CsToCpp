#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GerstnerWaterWaves.h")]
///<summary>Base class for the gerstner water wave generation. This can be overridden by either C++ classes or Blueprint classes.</summary>
public partial class UGerstnerWaterWaveGeneratorBase : UObject {
// GerstnerWaterWaveGeneratorBase
	public  void GenerateGerstnerWaves(TArray<FGerstnerWave> OutWaves) {}
}
