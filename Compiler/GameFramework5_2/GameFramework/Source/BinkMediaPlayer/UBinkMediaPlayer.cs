#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BinkMediaPlayer.h")]
///<summary>Implements a media player asset that can play movies and other media.</summary>
public partial class UBinkMediaPlayer : UObject {
// BinkMediaPlayer
	public  bool CanPause() { return default; }
	public  bool CanPlay() { return default; }
	public  FTimespan GetDuration() { return default; }
	public  float GetRate() { return default; }
	public  FTimespan GetTime() { return default; }
	public  string GetUrl() { return default; }
	public  bool IsLooping() { return default; }
	public  bool IsPaused() { return default; }
	public  bool IsPlaying() { return default; }
	public  bool IsStopped() { return default; }
	public  bool OpenUrl(string NewUrl) { return default; }
	public  void CloseUrl() {}
	public  bool Pause() { return default; }
	public  bool Play() { return default; }
	public  bool Rewind() { return default; }
	public  bool Seek(FTimespan InTime) { return default; }
	public  bool SetLooping(bool InLooping) { return default; }
	public  bool SetRate(float Rate) { return default; }
	public  void SetVolume(float Rate) {}
	public  void Stop() {}
	public  bool SupportsRate(float Rate,bool Unthinned) { return default; }
	public  bool SupportsScrubbing() { return default; }
	public  bool SupportsSeeking() { return default; }
	public  bool IsInitialized() { return default; }
	public  void Draw(UTexture texture,bool tonemap/*=false*/,int out_nits/*=10000*/,float alpha/*=1f*/,bool srgb_decode/*=false*/,bool hdr/*=false*/) {}
	public FOnBinkMediaPlayerMediaClosed OnMediaClosed;
	public FOnBinkMediaPlayerMediaOpened OnMediaOpened;
	public FOnBinkMediaPlayerMediaReachedEnd OnMediaReachedEnd;
	public FOnBinkMediaPlayerMediaEvent OnPlaybackSuspended;
	public bool Looping;
	public bool StartImmediately;
	public bool DelayedOpen;
	public FVector2D BinkDestinationUpperLeft;
	public FVector2D BinkDestinationLowerRight;
	public string URL;
	public EBinkMediaPlayerBinkBufferModes BinkBufferMode;
	public EBinkMediaPlayerBinkSoundTrack BinkSoundTrack;
	public int BinkSoundTrackStart;
	public EBinkMediaPlayerBinkDrawStyle BinkDrawStyle;
	public int BinkLayerDepth;
}
