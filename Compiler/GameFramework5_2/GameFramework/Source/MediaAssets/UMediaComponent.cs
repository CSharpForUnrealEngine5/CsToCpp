#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaComponent.h")]
public partial class UMediaComponent : UActorComponent {
// MediaComponent
	public  UMediaPlayer GetMediaPlayer() { return default; }
	public  UMediaTexture GetMediaTexture() { return default; }
	public UMediaTexture MediaTexture;
	public UMediaPlayer MediaPlayer;
}
