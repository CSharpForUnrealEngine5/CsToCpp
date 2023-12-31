namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Lookup table for distributions.</summary>
[CppInclude("Distributions/Distribution.h")]
public partial struct FDistributionLookupTable {
	public float TimeScale;
	public float TimeBias;
	public TArray<float> Values;
	public byte Op;
	public byte EntryCount;
	public byte EntryStride;
	public byte SubEntryStride;
	public byte LockFlag;
}
