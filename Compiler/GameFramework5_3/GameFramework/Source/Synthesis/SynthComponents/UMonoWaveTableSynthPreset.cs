namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UStruct Mono Wave Table Synth Preset</summary>
[CppInclude("SynthComponents/SynthComponentMonoWaveTable.h")]
public partial class UMonoWaveTableSynthPreset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name the preset</summary>
	public string PresetName;
	///<summary>Lock wavetables to evenly spaced keyframes that can be edited vertically only (will re-sample)</summary>
	public bool bLockKeyframesToGridBool;
	///<summary>How many evenly-spaced keyframes to use when LockKeyframesToGrid is true</summary>
	public int LockKeyframesToGrid;
	///<summary>How many samples will be taken of the curve from time = [0.0, 1.0]</summary>
	public int WaveTableResolution;
	///<summary>Wave Table Editor</summary>
	public TArray<FRuntimeFloatCurve> WaveTable;
	///<summary>Normalize the WaveTable data? False will allow clipping, True will normalize the tables when sent to the synth for rendering</summary>
	public bool bNormalizeWaveTables;
}
