namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Synchronization Source using the Media Player framework</summary>
[CppInclude("MediaPlayerTimeSynchronizationSource.h")]
public partial class UMediaPlayerTimeSynchronizationSource : UTimeSynchronizationSource {
	public static UClass StaticClass() {return default;}
	///<summary>Media source asset of this input</summary>
	public UMediaSource MediaSource;
	///<summary>Texture linked to the media player</summary>
	public UMediaTexture MediaTexture;
}
