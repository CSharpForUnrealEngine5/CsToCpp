#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Synchronization Source using the Media Player framework</summary>
[CppInclude("MediaPlayerTimeSynchronizationSource.h")]
public partial class UMediaPlayerTimeSynchronizationSource : UTimeSynchronizationSource {
	///<summary>Media source asset of this input</summary>
	public UMediaSource MediaSource;
	///<summary>Texture linked to the media player</summary>
	public UMediaTexture MediaTexture;
}
