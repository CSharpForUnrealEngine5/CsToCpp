namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Serialized WaveTable data, that supports multiple bit depth formats.</summary>
[CppInclude("WaveTable.h")]
public partial struct FWaveTableData {
	public EWaveTableBitDepth BitDepth;
	public TArray<byte> Data;
	public float FinalValue;
}
