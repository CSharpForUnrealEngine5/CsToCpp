#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for the gerstner water wave generation. This can be overridden by either C++ classes or Blueprint classes.</summary>
[CppInclude("GerstnerWaterWaves.h")]
public partial class UGerstnerWaterWaveGeneratorBase : UObject {
	///<summary>GenerateGerstnerWaves</summary>
	public  void GenerateGerstnerWaves(TArray<FGerstnerWave> OutWaves) {}
}
