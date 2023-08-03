#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Windows target platform. The first instance of this class is initialized in</summary>
[CppInclude("WindowsTargetSettings.h")]
public partial class UWindowsTargetSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Select which RHI to use. Make sure its also selected as a Targeted RHI. Requires Editor restart.</summary>
	public EDefaultGraphicsRHI DefaultGraphicsRHI;
	///<summary>TargetedRHIs_DEPRECATED</summary>
	public TArray<string> TargetedRHIs_DEPRECATED;
	///<summary>D3D12TargetedShaderFormats</summary>
	public TArray<string> D3D12TargetedShaderFormats;
	///<summary>D3D11TargetedShaderFormats</summary>
	public TArray<string> D3D11TargetedShaderFormats;
	///<summary>VulkanTargetedShaderFormats</summary>
	public TArray<string> VulkanTargetedShaderFormats;
	///<summary>The compiler version to use for this project. May be different to the chosen IDE.</summary>
	public ECompilerVersion Compiler;
	///<summary>Sample rate to run the audio mixer with.</summary>
	public int AudioSampleRate;
	///<summary>The amount of audio to compute each callback block. Lower values decrease latency but may increase CPU cost.</summary>
	public int AudioCallbackBufferFrameSize;
	///<summary>The number of buffers to keep enqueued. More buffers increases latency, but can compensate for variable compute availability in audio callbacks on some platforms.</summary>
	public int AudioNumBuffersToEnqueue;
	///<summary>The max number of channels (voices) to limit for this platform. The max channels used will be the minimum of this value and the global audio quality settings. A value of 0 will not apply a platform channel count max.</summary>
	public int AudioMaxChannels;
	///<summary>The number of workers to use to compute source audio. Will only use up to the max number of sources. Will evenly divide sources to each source worker.</summary>
	public int AudioNumSourceWorkers;
	///<summary>Which of the currently enabled spatialization plugins to use.</summary>
	public string SpatializationPlugin;
	///<summary>Which of the currently enabled source data override plugins to use.</summary>
	public string SourceDataOverridePlugin;
	///<summary>Which of the currently enabled reverb plugins to use.</summary>
	public string ReverbPlugin;
	///<summary>Which of the currently enabled occlusion plugins to use.</summary>
	public string OcclusionPlugin;
	///<summary>Various overrides for how this platform should handle compression and decompression</summary>
	public FPlatformRuntimeAudioCompressionOverrides CompressionOverrides;
	///<summary>This determines the max amount of memory that should be used for the cache at any given time. If set low (&lt;= 8 MB), it lowers the size of individual chunks of audio during cook.</summary>
	public int CacheSizeKB;
	///<summary>This overrides the default max chunk size used when chunking audio for stream caching (ignored if &lt; 0)</summary>
	public int MaxChunkSizeOverrideKB;
	///<summary>bResampleForDevice</summary>
	public bool bResampleForDevice;
	///<summary>Mapping of which sample rates are used for each sample rate quality for a specific platform.</summary>
	public float MaxSampleRate;
	///<summary>HighSampleRate</summary>
	public float HighSampleRate;
	///<summary>MedSampleRate</summary>
	public float MedSampleRate;
	///<summary>LowSampleRate</summary>
	public float LowSampleRate;
	///<summary>MinSampleRate</summary>
	public float MinSampleRate;
	///<summary>Scales all compression qualities when cooking to this platform. For example, 0.5 will halve all compression qualities, and 1.0 will leave them unchanged.</summary>
	public float CompressionQualityModifier;
	///<summary>When set to anything beyond 0, this will ensure any SoundWaves longer than this value, in seconds, to stream directly off of the disk.</summary>
	public float AutoStreamingThreshold;
	///<summary>Quality Level to COOK SoundCues at (if set, all other levels will be stripped by the cooker).</summary>
	public int SoundCueCookQualityIndex;
}
