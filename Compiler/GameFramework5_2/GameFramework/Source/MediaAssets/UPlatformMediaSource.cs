#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlatformMediaSource.h")]
///<summary>A media source that selects other media sources based on target platform.</summary>
public partial class UPlatformMediaSource : UMediaSource {
// PlatformMediaSource
	public TMap<string,UMediaSource> PlatformMediaSources;
	public UMediaSource MediaSource;
}
