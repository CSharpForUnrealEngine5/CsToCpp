#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimecodeSynchronizer.h")]
public partial struct FTimecodeSynchronizerActiveTimecodedInputSource {
	public bool bIsReady;
	public bool bCanBeSynchronized;
	public int TotalNumberOfSamples;
	public UTimeSynchronizationSource InputSource;
}
