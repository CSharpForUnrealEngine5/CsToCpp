#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the ImgMedia module.</summary>
[CppInclude("ImgMediaSettings.h")]
public partial class UImgMediaSettings : UObject {
	///<summary>Default frame rate to use if none was specified in image sequence or media source (default = 1/24).</summary>
	public FFrameRate DefaultFrameRate;
	///<summary>If there is not enough bandwidth to play the media, then lower it (for example by skipping frames) to try and get playback.</summary>
	public bool BandwidthThrottlingEnabled;
	///<summary>Percentage of cache to use for frames behind the play head (default = 25%).</summary>
	public float CacheBehindPercentage;
	///<summary>Maximum size of the look-ahead cache (in GB; default = 1 GB).</summary>
	public float CacheSizeGB;
	///<summary>Maximum number of image caching threads to use (0 = number of cores, default = 2).</summary>
	public int CacheThreads;
	///<summary>Size of the stack for each caching thread (in kB; default = 128).</summary>
	public int CacheThreadStackSizeKB;
	///<summary>Maximum size of the global look-ahead cache (in GB; default = 1 GB). Must be greater or equal to CacheSizeGB.</summary>
	public float GlobalCacheSizeGB;
	///<summary>Whether to use the global cache or not.</summary>
	public bool UseGlobalCache;
	///<summary>Number of worker threads to use when decoding EXR images (0 = auto).</summary>
	public uint ExrDecoderThreads;
	///<summary>Name of default media source proxy URLs (default = &#39;proxy&#39;).</summary>
	public string DefaultProxy;
	///<summary>Whether to enable image sequence proxies (default = false).</summary>
	public bool UseDefaultProxy;
}
