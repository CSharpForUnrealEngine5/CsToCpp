namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimecodeSynchronizer.h")]
public partial struct FTimecodeSynchronizerActiveTimecodedInputSource {
	public bool bIsReady;
	public bool bCanBeSynchronized;
	public int TotalNumberOfSamples;
	public UTimeSynchronizationSource InputSource;
}
