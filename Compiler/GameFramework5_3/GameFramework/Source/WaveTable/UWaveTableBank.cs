namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveTableBank.h")]
public partial class UWaveTableBank : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Sampling mode used for the bank.</summary>
	public EWaveTableSamplingMode SampleMode;
	///<summary>Number of samples cached for each entry in the given bank.</summary>
	public EWaveTableResolution Resolution;
	///<summary>Number of samples cached for each entry in the given bank.</summary>
	public int SampleRate;
	///<summary>Determines if output from curve/wavetable are to be clamped between</summary>
	public bool bBipolar;
	///<summary>Sum total size of all WaveTable data within the given bank</summary>
	public float WaveTableSizeMB;
	///<summary>Entries</summary>
	public TArray<FWaveTableBankEntry> Entries;
}
