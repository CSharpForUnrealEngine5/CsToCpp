namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveTableBank.h")]
public partial class UWaveTableBank : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Number of samples cached for each curve in the given bank.</summary>
	public EWaveTableResolution Resolution;
	///<summary>Determines if output from curve/wavetable are to be clamped between</summary>
	public bool bBipolar;
	///<summary>Sum total size of all WaveTable data within the given bank</summary>
	public float WaveTableSizeMB;
	///<summary>Length of all WaveTable samples in bank in seconds (at 48kHz)</summary>
	public float WaveTableLengthSec;
	///<summary>Tables within the given bank</summary>
	public TArray<FWaveTableBankEntry> Entries;
}
