#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Shared/MediaSourceRenderer.h")]
///<summary>Renders a media source to a texture in editor builds.</summary>
public partial class UMediaSourceRenderer : UObject {
// MediaSourceRenderer
	public  void OnSeekCompleted() {}
	public UMediaPlayer MediaPlayer;
	public UMediaSource MediaSource;
	public UMediaTexture MediaTexture;
}
