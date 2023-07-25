#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VolumeCache.h")]
public partial class UVolumeCache : UObject {
// VolumeCache
	public string FilePath;
	public EVolumeCacheType CacheType;
	public FIntVector Resolution;
	public int FrameRangeStart;
	public int FrameRangeEnd;
}
