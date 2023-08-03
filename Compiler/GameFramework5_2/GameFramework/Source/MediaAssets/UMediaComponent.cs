#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaComponent.h")]
public partial class UMediaComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Get the media player that this component owns</summary>
	public  UMediaPlayer GetMediaPlayer() { return default; }
	///<summary>Get the media texture that this component owns, bound to its media player.</summary>
	public  UMediaTexture GetMediaTexture() { return default; }
	///<summary>This component&#39;s media texture</summary>
	public UMediaTexture MediaTexture;
	///<summary>This component&#39;s media player</summary>
	public UMediaPlayer MediaPlayer;
}
