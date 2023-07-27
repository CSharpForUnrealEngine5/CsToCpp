#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaPlateComponent.h")]
///<summary>This is a component for AMediaPlate that can play and show media in the world.</summary>
public partial class UMediaPlateComponent : UActorComponent {
// MediaPlateComponent
	public  UMediaPlayer GetMediaPlayer() { return default; }
	public  UMediaTexture GetMediaTexture(int Index/*=0*/) { return default; }
	public  void Open() {}
	public  void Play() {}
	public  void Pause() {}
	public  bool Rewind() { return default; }
	public  bool Seek(FTimespan Time) { return default; }
	public  void Close() {}
	public  bool IsMediaPlatePlaying() { return default; }
	public  bool GetLoop() { return default; }
	public  void SetLoop(bool bInLoop) {}
	public bool bPlayOnOpen;
	public bool bAutoPlay;
	public bool bEnableAudio;
	public float StartTime;
	public UMediaSoundComponent SoundComponent;
	public UStaticMeshComponent StaticMeshComponent;
	public TArray<UStaticMeshComponent> Letterboxes;
	public UMediaPlaylist MediaPlaylist;
	public int PlaylistIndex;
	public FMediaSourceCacheSettings CacheSettings;
	public  void SetMeshRange(FVector2D InMeshRange) {}
	public  FVector2D GetMeshRange() { return default; }
	public  void SetPlayOnlyWhenVisible(bool bInPlayOnlyWhenVisible) {}
	public  bool GetIsAspectRatioAuto() { return default; }
	public  void SetIsAspectRatioAuto(bool bInIsAspectRatioAuto) {}
	public  float GetLetterboxAspectRatio() { return default; }
	public  void SetLetterboxAspectRatio(float AspectRatio) {}
	public bool bIsMediaPlatePlaying;
	public bool bPlayOnlyWhenVisible;
	public bool bLoop;
	public EMediaTextureVisibleMipsTiles VisibleMipsTilesCalculations;
	public float MipMapBias;
	public bool bIsAspectRatioAuto;
	public bool bEnableMipMapUpscaling;
	public int MipLevelToUpscale;
	public float LetterboxAspectRatio;
	public FVector2D MeshRange;
	public UMediaTexture MediaTexture_DEPRECATED;
	public TArray<UMediaTexture> MediaTextures;
	public UMediaPlayer MediaPlayer;
	public  void OnMediaOpened(string DeviceUrl) {}
	public  void OnMediaEnd() {}
}
