namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for the gerstner water wave generation. This can be overridden by either C++ classes or Blueprint classes.</summary>
[CppInclude("GerstnerWaterWaves.h")]
public partial class UGerstnerWaterWaveGeneratorBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GenerateGerstnerWaves</summary>
	public void GenerateGerstnerWaves(TArray<FGerstnerWave> OutWaves) {}
}
