#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimecodeSynchronizer.h")]
public partial class UTimecodeSynchronizer : UTimecodeProvider {
// TimecodeSynchronizer
	public ETimecodeSynchronizationFrameRateSources FrameRateSource;
	public FFrameRate FixedFrameRate;
	public ETimecodeSynchronizationTimecodeType TimecodeProviderType;
	public UTimecodeProvider TimecodeProvider;
	public int MainSynchronizationSourceIndex;
	public bool bUsePreRollingTimecodeMarginOfErrors;
	public int PreRollingTimecodeMarginOfErrors;
	public bool bUsePreRollingTimeout;
	public float PreRollingTimeout;
	public TArray<UTimeSynchronizationSource> TimeSynchronizationInputSources;
	public TArray<UTimeSynchronizationSource> DynamicSources;
	public ETimecodeSynchronizationSyncMode SyncMode;
	public int FrameOffset;
	public int AutoFrameOffset;
	public bool bWithRollover;
	public TArray<FTimecodeSynchronizerActiveTimecodedInputSource> SynchronizedSources;
	public TArray<FTimecodeSynchronizerActiveTimecodedInputSource> NonSynchronizedSources;
	public UFixedFrameRateCustomTimeStep RegisteredCustomTimeStep;
	public UTimecodeProvider CachedPreviousTimecodeProvider;
	public UTimecodeProvider CachedProxiedTimecodeProvider;
	public int ActualFrameOffset;
}
