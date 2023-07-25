#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentMonoWaveTable.h")]
///<summary>UStruct Mono Wave Table Synth Preset</summary>
public partial class UMonoWaveTableSynthPreset : UObject {
// MonoWaveTableSynthPreset
	public string PresetName;
	public bool bLockKeyframesToGridBool;
	public int LockKeyframesToGrid;
	public int WaveTableResolution;
	public TArray<FRuntimeFloatCurve> WaveTable;
	public bool bNormalizeWaveTables;
}
