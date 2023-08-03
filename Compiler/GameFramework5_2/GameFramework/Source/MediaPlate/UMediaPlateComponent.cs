#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a component for AMediaPlate that can play and show media in the world.</summary>
[CppInclude("MediaPlateComponent.h")]
public partial class UMediaPlateComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Call this get our media player.</summary>
	public  UMediaPlayer GetMediaPlayer() { return default; }
	///<summary>Call this get our media texture.</summary>
	public  UMediaTexture GetMediaTexture(int Index/*=0*/) { return default; }
	///<summary>Call this to open the media.</summary>
	public  void Open() {}
	///<summary>Call this to start playing.</summary>
	public  void Play() {}
	///<summary>Call this to pause playback.</summary>
	public  void Pause() {}
	///<summary>Rewinds the media to the beginning.</summary>
	public  bool Rewind() { return default; }
	///<summary>Call this to seek to the specified playback time.</summary>
	public  bool Seek(FTimespan Time) { return default; }
	///<summary>Call this to close the media.</summary>
	public  void Close() {}
	///<summary>Call this to see if the media plate is playing.</summary>
	public  bool IsMediaPlatePlaying() { return default; }
	///<summary>Call this to see if we want to loop.</summary>
	public  bool GetLoop() { return default; }
	///<summary>Call this enable/disable looping.</summary>
	public  void SetLoop(bool bInLoop) {}
	///<summary>If set then play when opening the media.</summary>
	public bool bPlayOnOpen;
	///<summary>If set then start playing when this object is active.</summary>
	public bool bAutoPlay;
	///<summary>If set then enable audio.</summary>
	public bool bEnableAudio;
	///<summary>What time to start playing from (in seconds).</summary>
	public float StartTime;
	///<summary>Holds the component to play sound.</summary>
	public UMediaSoundComponent SoundComponent;
	///<summary>Holds the component for the mesh.</summary>
	public UStaticMeshComponent StaticMeshComponent;
	///<summary>Holds the component for the mesh.</summary>
	public TArray<UStaticMeshComponent> Letterboxes;
	///<summary>What media playlist to play.</summary>
	public UMediaPlaylist MediaPlaylist;
	///<summary>The current index of the source in the play list being played.</summary>
	public int PlaylistIndex;
	///<summary>Override the default cache settings.</summary>
	public FMediaSourceCacheSettings CacheSettings;
	///<summary>Set the arc size in degrees used for visible mips and tiles calculations, specific to the sphere.</summary>
	public  void SetMeshRange(FVector2D InMeshRange) {}
	///<summary>Return the arc size in degrees used for visible mips and tiles calculations, specific to the sphere.</summary>
	public  FVector2D GetMeshRange() { return default; }
	///<summary>Call this to set bPlayOnlyWhenVisible.</summary>
	public  void SetPlayOnlyWhenVisible(bool bInPlayOnlyWhenVisible) {}
	///<summary>Gets whether automatic aspect ratio is enabled.</summary>
	public  bool GetIsAspectRatioAuto() { return default; }
	///<summary>Sets whether automatic aspect ratio is enabled.</summary>
	public  void SetIsAspectRatioAuto(bool bInIsAspectRatioAuto) {}
	///<summary>Call this to get the aspect ratio of the screen.</summary>
	public  float GetLetterboxAspectRatio() { return default; }
	///<summary>Call this to set the aspect ratio of the screen.</summary>
	public  void SetLetterboxAspectRatio(float AspectRatio) {}
	///<summary>If true, then we want the media plate to play.</summary>
	public bool bIsMediaPlatePlaying;
	///<summary>If true then only allow playback when the media plate is visible.</summary>
	public bool bPlayOnlyWhenVisible;
	///<summary>If set then loop when we reach the end.</summary>
	public bool bLoop;
	///<summary>Visible mips and tiles calculation mode for the supported mesh types in MediaPlate. (Player restart on change.)</summary>
	public EMediaTextureVisibleMipsTiles VisibleMipsTilesCalculations;
	///<summary>Media texture mip map bias shared between the (image sequence) loader and the media texture sampler.</summary>
	public float MipMapBias;
	///<summary>If true then set the aspect ratio automatically based on the media.</summary>
	public bool bIsAspectRatioAuto;
	///<summary>If true then enable the use of MipLevelToUpscale as defined below.</summary>
	public bool bEnableMipMapUpscaling;
	///<summary>With exr playback, upscale into lower quality mips from this specified level. All levels including and above the specified value will be fully read.</summary>
	public int MipLevelToUpscale;
	///<summary>If &gt; 0, then this is the aspect ratio of our screen and</summary>
	public float LetterboxAspectRatio;
	///<summary>MeshRange</summary>
	public FVector2D MeshRange;
	///<summary>Superseded by MediaTextures.</summary>
	public UMediaTexture MediaTexture_DEPRECATED;
	///<summary>Holds the media textures.</summary>
	public TArray<UMediaTexture> MediaTextures;
	///<summary>This component&#39;s media player</summary>
	public UMediaPlayer MediaPlayer;
	///<summary>Called by the media player when the media opens.</summary>
	public  void OnMediaOpened(string DeviceUrl) {}
	///<summary>Called by the media player when the video ends.</summary>
	public  void OnMediaEnd() {}
}
