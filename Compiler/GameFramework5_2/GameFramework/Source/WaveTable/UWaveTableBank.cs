#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveTableBank.h")]
public partial class UWaveTableBank : UObject {
// WaveTableBank
	public EWaveTableResolution Resolution;
	public bool bBipolar;
	public float WaveTableSizeMB;
	public float WaveTableLengthSec;
	public TArray<FWaveTableBankEntry> Entries;
}
