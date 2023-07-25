#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WindowsTargetSettings.h")]
///<summary>Implements the settings for the Windows target platform. The first instance of this class is initialized in</summary>
public partial class UWindowsTargetSettings : UObject {
// WindowsTargetSettings
	public EDefaultGraphicsRHI DefaultGraphicsRHI;
	public TArray<string> TargetedRHIs_DEPRECATED;
	public TArray<string> D3D12TargetedShaderFormats;
	public TArray<string> D3D11TargetedShaderFormats;
	public TArray<string> VulkanTargetedShaderFormats;
	public ECompilerVersion Compiler;
	public int AudioSampleRate;
	public int AudioCallbackBufferFrameSize;
	public int AudioNumBuffersToEnqueue;
	public int AudioMaxChannels;
	public int AudioNumSourceWorkers;
	public string SpatializationPlugin;
	public string SourceDataOverridePlugin;
	public string ReverbPlugin;
	public string OcclusionPlugin;
	public FPlatformRuntimeAudioCompressionOverrides CompressionOverrides;
	public int CacheSizeKB;
	public int MaxChunkSizeOverrideKB;
	public bool bResampleForDevice;
	public float MaxSampleRate;
	public float HighSampleRate;
	public float MedSampleRate;
	public float LowSampleRate;
	public float MinSampleRate;
	public float CompressionQualityModifier;
	public float AutoStreamingThreshold;
	public int SoundCueCookQualityIndex;
}
