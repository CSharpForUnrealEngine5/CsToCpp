#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimecodeSynchronizer.h")]
public partial class UTimecodeSynchronizer : UTimecodeProvider {
	///<summary>Frame Rate Source.</summary>
	public ETimecodeSynchronizationFrameRateSources FrameRateSource;
	///<summary>The fixed framerate to use.</summary>
	public FFrameRate FixedFrameRate;
	///<summary>Use a Timecode Provider.</summary>
	public ETimecodeSynchronizationTimecodeType TimecodeProviderType;
	///<summary>Custom strategy to tick in a interval.</summary>
	public UTimecodeProvider TimecodeProvider;
	///<summary>Index of the source that drives the synchronized Timecode.</summary>
	public int MainSynchronizationSourceIndex;
	///<summary>Enable verification of margin between synchronized time and source time</summary>
	public bool bUsePreRollingTimecodeMarginOfErrors;
	///<summary>Maximum gap size between synchronized time and source time</summary>
	public int PreRollingTimecodeMarginOfErrors;
	///<summary>Enable PreRoll timeout</summary>
	public bool bUsePreRollingTimeout;
	///<summary>How long to wait for all source to be ready</summary>
	public float PreRollingTimeout;
	///<summary>! ONLY MODIFY THESE IN EDITOR</summary>
	public TArray<UTimeSynchronizationSource> TimeSynchronizationInputSources;
	///<summary>DynamicSources</summary>
	public TArray<UTimeSynchronizationSource> DynamicSources;
	///<summary>What mode will be used for synchronization.</summary>
	public ETimecodeSynchronizationSyncMode SyncMode;
	///<summary>When UserDefined mode is used, the number of frames delayed from the Provider&#39;s timecode.</summary>
	public int FrameOffset;
	///<summary>Similar to FrameOffset.</summary>
	public int AutoFrameOffset;
	///<summary>Whether or not the specified Provider&#39;s timecode rolls over. (Rollover is expected to occur at Timecode 24:00:00:00).</summary>
	public bool bWithRollover;
	///<summary>Sources used for synchronization</summary>
	public TArray<FTimecodeSynchronizerActiveTimecodedInputSource> SynchronizedSources;
	///<summary>Sources that wants to be synchronized</summary>
	public TArray<FTimecodeSynchronizerActiveTimecodedInputSource> NonSynchronizedSources;
	///<summary>RegisteredCustomTimeStep</summary>
	public UFixedFrameRateCustomTimeStep RegisteredCustomTimeStep;
	///<summary>CachedPreviousTimecodeProvider</summary>
	public UTimecodeProvider CachedPreviousTimecodeProvider;
	///<summary>CachedProxiedTimecodeProvider</summary>
	public UTimecodeProvider CachedProxiedTimecodeProvider;
	///<summary>ActualFrameOffset</summary>
	public int ActualFrameOffset;
}
