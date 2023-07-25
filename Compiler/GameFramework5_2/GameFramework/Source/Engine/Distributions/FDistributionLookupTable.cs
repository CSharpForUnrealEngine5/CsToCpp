#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Distributions/Distribution.h")]
///<summary>Lookup table for distributions.</summary>
public partial struct FDistributionLookupTable {
// DistributionLookupTable
	public float TimeScale;
	public float TimeBias;
	public TArray<float> Values;
	public byte Op;
	public byte EntryCount;
	public byte EntryStride;
	public byte SubEntryStride;
	public byte LockFlag;
}
