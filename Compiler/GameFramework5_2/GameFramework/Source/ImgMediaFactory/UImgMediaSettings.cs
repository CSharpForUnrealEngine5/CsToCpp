#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImgMediaSettings.h")]
///<summary>Settings for the ImgMedia module.</summary>
public partial class UImgMediaSettings : UObject {
// ImgMediaSettings
	public FFrameRate DefaultFrameRate;
	public bool BandwidthThrottlingEnabled;
	public float CacheBehindPercentage;
	public float CacheSizeGB;
	public int CacheThreads;
	public int CacheThreadStackSizeKB;
	public float GlobalCacheSizeGB;
	public bool UseGlobalCache;
	public uint ExrDecoderThreads;
	public string DefaultProxy;
	public bool UseDefaultProxy;
}
