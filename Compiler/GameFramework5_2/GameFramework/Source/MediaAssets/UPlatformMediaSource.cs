#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A media source that selects other media sources based on target platform.</summary>
[CppInclude("PlatformMediaSource.h")]
public partial class UPlatformMediaSource : UMediaSource {
	///<summary>Media sources per platform.</summary>
	public TMap<string,UMediaSource> PlatformMediaSources;
	///<summary>Default media source.</summary>
	public UMediaSource MediaSource;
}
