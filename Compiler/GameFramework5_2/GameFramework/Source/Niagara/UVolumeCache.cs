#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VolumeCache.h")]
public partial class UVolumeCache : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>File path to load</summary>
	public string FilePath;
	///<summary>CacheType</summary>
	public EVolumeCacheType CacheType;
	///<summary>Resolution</summary>
	public FIntVector Resolution;
	///<summary>FrameRangeStart</summary>
	public int FrameRangeStart;
	///<summary>FrameRangeEnd</summary>
	public int FrameRangeEnd;
}
