#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaPlayer.h")]
///<summary>Implements a media player asset that can play movies and other media sources.</summary>
public partial class UMediaPlayer : UObject {
// MediaPlayer
	public  bool CanPause() { return default; }
	public  bool CanPlaySource(UMediaSource MediaSource) { return default; }
	public  bool CanPlayUrl(string Url) { return default; }
	public  void Close() {}
	public  int GetAudioTrackChannels(int TrackIndex,int FormatIndex) { return default; }
	public  int GetAudioTrackSampleRate(int TrackIndex,int FormatIndex) { return default; }
	public  string GetAudioTrackType(int TrackIndex,int FormatIndex) { return default; }
	public  string GetDesiredPlayerName() { return default; }
	public  FTimespan GetDuration() { return default; }
	public  float GetHorizontalFieldOfView() { return default; }
	public  string GetMediaName() { return default; }
	public  int GetNumTracks(EMediaPlayerTrack TrackType) { return default; }
	public  int GetNumTrackFormats(EMediaPlayerTrack TrackType,int TrackIndex) { return default; }
	public  string GetPlayerName() { return default; }
	public  UMediaPlaylist GetPlaylist() { return default; }
	public  int GetPlaylistIndex() { return default; }
	public  float GetRate() { return default; }
	public  int GetSelectedTrack(EMediaPlayerTrack TrackType) { return default; }
	public  void GetSupportedRates(TArray<FFloatRange> OutRates,bool Unthinned) {}
	public  FTimespan GetTime() { return default; }
	public  UMediaTimeStampInfo GetTimeStamp() { return default; }
	public  string GetTrackDisplayName(EMediaPlayerTrack TrackType,int TrackIndex) { return default; }
	public  int GetTrackFormat(EMediaPlayerTrack TrackType,int TrackIndex) { return default; }
	public  string GetTrackLanguage(EMediaPlayerTrack TrackType,int TrackIndex) { return default; }
	public  string GetUrl() { return default; }
	public  float GetVerticalFieldOfView() { return default; }
	public  float GetVideoTrackAspectRatio(int TrackIndex,int FormatIndex) { return default; }
	public  FIntPoint GetVideoTrackDimensions(int TrackIndex,int FormatIndex) { return default; }
	public  float GetVideoTrackFrameRate(int TrackIndex,int FormatIndex) { return default; }
	public  FFloatRange GetVideoTrackFrameRates(int TrackIndex,int FormatIndex) { return default; }
	public  string GetVideoTrackType(int TrackIndex,int FormatIndex) { return default; }
	public  FRotator GetViewRotation() { return default; }
	public  FTimespan GetTimeDelay() { return default; }
	public  bool HasError() { return default; }
	public  bool IsBuffering() { return default; }
	public  bool IsConnecting() { return default; }
	public  bool IsLooping() { return default; }
	public  bool IsPaused() { return default; }
	public  bool IsPlaying() { return default; }
	public  bool IsPreparing() { return default; }
	public  bool IsClosed() { return default; }
	public  bool IsReady() { return default; }
	public  bool Next() { return default; }
	public  bool OpenFile(string FilePath) { return default; }
	public  bool OpenPlaylist(UMediaPlaylist InPlaylist) { return default; }
	public  bool OpenPlaylistIndex(UMediaPlaylist InPlaylist,int Index) { return default; }
	public  bool OpenSource(UMediaSource MediaSource) { return default; }
	public  bool OpenSourceWithOptions(UMediaSource MediaSource,FMediaPlayerOptions Options) { return default; }
	public  void OpenSourceLatent(UObject WorldContextObject,FLatentActionInfo LatentInfo,UMediaSource MediaSource,FMediaPlayerOptions Options,bool bSuccess) {}
	public  bool OpenUrl(string Url) { return default; }
	public  bool Pause() { return default; }
	public  bool Play() { return default; }
	public  void PlayAndSeek() {}
	public  bool Previous() { return default; }
	public  bool Reopen() { return default; }
	public  bool Rewind() { return default; }
	public  bool Seek(FTimespan Time) { return default; }
	public  bool SelectTrack(EMediaPlayerTrack TrackType,int TrackIndex) { return default; }
	public  void SetBlockOnTime(FTimespan Time) {}
	public  void SetDesiredPlayerName(string PlayerName) {}
	public  bool SetLooping(bool Looping) { return default; }
	public  void SetMediaOptions(UMediaSource Options) {}
	public  bool SetRate(float Rate) { return default; }
	public  bool SetNativeVolume(float Volume) { return default; }
	public  bool SetTrackFormat(EMediaPlayerTrack TrackType,int TrackIndex,int FormatIndex) { return default; }
	public  bool SetVideoTrackFrameRate(int TrackIndex,int FormatIndex,float FrameRate) { return default; }
	public  bool SetViewField(float Horizontal,float Vertical,bool Absolute) { return default; }
	public  bool SetViewRotation(FRotator Rotation,bool Absolute) { return default; }
	public  void SetTimeDelay(FTimespan TimeDelay) {}
	public  bool SupportsRate(float Rate,bool Unthinned) { return default; }
	public  bool SupportsScrubbing() { return default; }
	public  bool SupportsSeeking() { return default; }
	public FOnMediaPlayerMediaEvent OnEndReached;
	public FOnMediaPlayerMediaEvent OnMediaClosed;
	public FOnMediaPlayerMediaOpened OnMediaOpened;
	public FOnMediaPlayerMediaOpenFailed OnMediaOpenFailed;
	public FOnMediaPlayerMediaEvent OnPlaybackResumed;
	public FOnMediaPlayerMediaEvent OnPlaybackSuspended;
	public FOnMediaPlayerMediaEvent OnSeekCompleted;
	public FOnMediaPlayerMediaEvent OnTracksChanged;
	public FOnMediaPlayerMediaEvent OnMetadataChanged;
	public FTimespan CacheAhead;
	public FTimespan CacheBehind;
	public FTimespan CacheBehindGame;
	public bool NativeAudioOut;
	public bool PlayOnOpen;
	public bool Shuffle;
	public bool Loop;
	public UMediaPlaylist Playlist;
	public int PlaylistIndex;
	public FTimespan TimeDelay;
	public float HorizontalFieldOfView;
	public float VerticalFieldOfView;
	public FRotator ViewRotation;
	public FGuid PlayerGuid;
	public bool AffectedByPIEHandling;
}
