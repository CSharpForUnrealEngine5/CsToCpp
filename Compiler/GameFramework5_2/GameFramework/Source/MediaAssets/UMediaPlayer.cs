namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a media player asset that can play movies and other media sources.</summary>
[CppInclude("MediaPlayer.h")]
public partial class UMediaPlayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether media playback can be paused right now.</summary>
	public bool CanPause() { return default; }
	///<summary>Check whether the specified media source can be played by this player.</summary>
	public bool CanPlaySource(UMediaSource MediaSource) { return default; }
	///<summary>Check whether the specified URL can be played by this player.</summary>
	public bool CanPlayUrl(string Url) { return default; }
	///<summary>Close the currently open media, if any.</summary>
	public void Close() {}
	///<summary>Get the number of channels in the specified audio track.</summary>
	public int GetAudioTrackChannels(int TrackIndex,int FormatIndex) { return default; }
	///<summary>Get the sample rate of the specified audio track.</summary>
	public int GetAudioTrackSampleRate(int TrackIndex,int FormatIndex) { return default; }
	///<summary>Get the type of the specified audio track format.</summary>
	public string GetAudioTrackType(int TrackIndex,int FormatIndex) { return default; }
	///<summary>Get the name of the current desired native player.</summary>
	public string GetDesiredPlayerName() { return default; }
	///<summary>Get the media&#39;s duration.</summary>
	public FTimespan GetDuration() { return default; }
	///<summary>Get the current horizontal field of view (only for 360 videos).</summary>
	public float GetHorizontalFieldOfView() { return default; }
	///<summary>Get the human readable name of the currently loaded media source.</summary>
	public virtual FText GetMediaName() { return default; }
	///<summary>Get the number of tracks of the given type.</summary>
	public int GetNumTracks(EMediaPlayerTrack TrackType) { return default; }
	///<summary>Get the number of formats of the specified track.</summary>
	public int GetNumTrackFormats(EMediaPlayerTrack TrackType,int TrackIndex) { return default; }
	///<summary>Get the name of the current native media player.</summary>
	public string GetPlayerName() { return default; }
	///<summary>Get the current play list.</summary>
	public UMediaPlaylist GetPlaylist() { return default; }
	///<summary>Get the current play list index.</summary>
	public int GetPlaylistIndex() { return default; }
	///<summary>Get the media&#39;s current playback rate.</summary>
	public float GetRate() { return default; }
	///<summary>Get the index of the currently selected track of the given type.</summary>
	public int GetSelectedTrack(EMediaPlayerTrack TrackType) { return default; }
	///<summary>Get the supported playback rates.</summary>
	public void GetSupportedRates(TArray<FFloatRange> OutRates,bool Unthinned) {}
	///<summary>Get the media&#39;s current playback time.</summary>
	public FTimespan GetTime() { return default; }
	///<summary>Get the media&#39;s current playback timestamp.</summary>
	public UMediaTimeStampInfo GetTimeStamp() { return default; }
	///<summary>Get the human readable name of the specified track.</summary>
	public FText GetTrackDisplayName(EMediaPlayerTrack TrackType,int TrackIndex) { return default; }
	///<summary>Get the index of the active format of the specified track type.</summary>
	public int GetTrackFormat(EMediaPlayerTrack TrackType,int TrackIndex) { return default; }
	///<summary>Get the language tag of the specified track.</summary>
	public string GetTrackLanguage(EMediaPlayerTrack TrackType,int TrackIndex) { return default; }
	///<summary>Get the URL of the currently loaded media, if any.</summary>
	public string GetUrl() { return default; }
	///<summary>Get the current vertical field of view (only for 360 videos).</summary>
	public float GetVerticalFieldOfView() { return default; }
	///<summary>Get the aspect ratio of the specified video track.</summary>
	public float GetVideoTrackAspectRatio(int TrackIndex,int FormatIndex) { return default; }
	///<summary>Get the current dimensions of the specified video track.</summary>
	public FIntPoint GetVideoTrackDimensions(int TrackIndex,int FormatIndex) { return default; }
	///<summary>Get the frame rate of the specified video track.</summary>
	public float GetVideoTrackFrameRate(int TrackIndex,int FormatIndex) { return default; }
	///<summary>Get the supported range of frame rates of the specified video track.</summary>
	public FFloatRange GetVideoTrackFrameRates(int TrackIndex,int FormatIndex) { return default; }
	///<summary>Get the type of the specified video track format.</summary>
	public string GetVideoTrackType(int TrackIndex,int FormatIndex) { return default; }
	///<summary>Get the current view rotation (only for 360 videos).</summary>
	public FRotator GetViewRotation() { return default; }
	///<summary>Delay of the player&#39;s time.</summary>
	public FTimespan GetTimeDelay() { return default; }
	///<summary>Check whether the player is in an error state.</summary>
	public bool HasError() { return default; }
	///<summary>Check whether playback is buffering data.</summary>
	public bool IsBuffering() { return default; }
	///<summary>Check whether the player is currently connecting to a media source.</summary>
	public bool IsConnecting() { return default; }
	///<summary>Check whether playback is looping.</summary>
	public bool IsLooping() { return default; }
	///<summary>Check whether playback is currently paused.</summary>
	public bool IsPaused() { return default; }
	///<summary>Check whether playback has started.</summary>
	public bool IsPlaying() { return default; }
	///<summary>Check whether the media is currently opening or buffering.</summary>
	public bool IsPreparing() { return default; }
	///<summary>Whether media is currently closed.</summary>
	public bool IsClosed() { return default; }
	///<summary>Check whether media is ready for playback.</summary>
	public bool IsReady() { return default; }
	///<summary>Open the next item in the current play list.</summary>
	public bool Next() { return default; }
	///<summary>Opens the specified media file path.</summary>
	public bool OpenFile(string FilePath) { return default; }
	///<summary>Open the first media source in the specified play list.</summary>
	public bool OpenPlaylist(UMediaPlaylist InPlaylist) { return default; }
	///<summary>Open a particular media source in the specified play list.</summary>
	public bool OpenPlaylistIndex(UMediaPlaylist InPlaylist,int Index) { return default; }
	///<summary>Open the specified media source.</summary>
	public bool OpenSource(UMediaSource MediaSource) { return default; }
	///<summary>Open the specified media source with supplied options applied.</summary>
	public bool OpenSourceWithOptions(UMediaSource MediaSource,FMediaPlayerOptions Options) { return default; }
	///<summary>Open the specified media source with options using a latent action.</summary>
	public void OpenSourceLatent(UObject WorldContextObject,FLatentActionInfo LatentInfo,UMediaSource MediaSource,FMediaPlayerOptions Options,bool bSuccess) {}
	///<summary>Opens the specified media URL.</summary>
	public bool OpenUrl(string Url) { return default; }
	///<summary>Pauses media playback.</summary>
	public bool Pause() { return default; }
	///<summary>Starts media playback.</summary>
	public bool Play() { return default; }
	///<summary>Starts playback from the media opened event, but can be used elsewhere.</summary>
	public void PlayAndSeek() {}
	///<summary>Open the previous item in the current play list.</summary>
	public bool Previous() { return default; }
	///<summary>Reopens the currently opened media or play list.</summary>
	public bool Reopen() { return default; }
	///<summary>Rewinds the media to the beginning.</summary>
	public bool Rewind() { return default; }
	///<summary>Seeks to the specified playback time.</summary>
	public bool Seek(FTimespan Time) { return default; }
	///<summary>Select the active track of the given type.</summary>
	public bool SelectTrack(EMediaPlayerTrack TrackType,int TrackIndex) { return default; }
	///<summary>Set the time on which to block.</summary>
	public void SetBlockOnTime(FTimespan Time) {}
	///<summary>Set the name of the desired native player.</summary>
	public void SetDesiredPlayerName(string PlayerName) {}
	///<summary>Enables or disables playback looping.</summary>
	public bool SetLooping(bool Looping) { return default; }
	///<summary>Sets the media options used by the player.</summary>
	public void SetMediaOptions(UMediaSource Options) {}
	///<summary>Changes the media&#39;s playback rate.</summary>
	public bool SetRate(float Rate) { return default; }
	///<summary>Set the volume on the native player if not mixing with Sound Wave asset.</summary>
	public bool SetNativeVolume(float Volume) { return default; }
	///<summary>Set the format on the specified track.</summary>
	public bool SetTrackFormat(EMediaPlayerTrack TrackType,int TrackIndex,int FormatIndex) { return default; }
	///<summary>Set the frame rate of the specified video track.</summary>
	public bool SetVideoTrackFrameRate(int TrackIndex,int FormatIndex,float FrameRate) { return default; }
	///<summary>Set the field of view (only for 360 videos).</summary>
	public bool SetViewField(float Horizontal,float Vertical,bool Absolute) { return default; }
	///<summary>Set the view&#39;s rotation (only for 360 videos).</summary>
	public bool SetViewRotation(FRotator Rotation,bool Absolute) { return default; }
	///<summary>Delay of the player&#39;s time.</summary>
	public void SetTimeDelay(FTimespan TimeDelay) {}
	///<summary>Check whether the specified playback rate is supported.</summary>
	public bool SupportsRate(float Rate,bool Unthinned) { return default; }
	///<summary>Check whether the currently loaded media supports scrubbing.</summary>
	public bool SupportsScrubbing() { return default; }
	///<summary>Check whether the currently loaded media can jump to a certain position.</summary>
	public bool SupportsSeeking() { return default; }
	///<summary>A delegate that is invoked when playback has reached the end of the media.</summary>
	public FOnMediaPlayerMediaEvent OnEndReached;
	///<summary>A delegate that is invoked when a media source has been closed.</summary>
	public FOnMediaPlayerMediaEvent OnMediaClosed;
	///<summary>A delegate that is invoked when a media source has been opened.</summary>
	public FOnMediaPlayerMediaOpened OnMediaOpened;
	///<summary>A delegate that is invoked when a media source has failed to open.</summary>
	public FOnMediaPlayerMediaOpenFailed OnMediaOpenFailed;
	///<summary>A delegate that is invoked when media playback has been resumed.</summary>
	public FOnMediaPlayerMediaEvent OnPlaybackResumed;
	///<summary>A delegate that is invoked when media playback has been suspended.</summary>
	public FOnMediaPlayerMediaEvent OnPlaybackSuspended;
	///<summary>A delegate that is invoked when a seek operation completed successfully.</summary>
	public FOnMediaPlayerMediaEvent OnSeekCompleted;
	///<summary>A delegate that is invoked when the media track collection changed.</summary>
	public FOnMediaPlayerMediaEvent OnTracksChanged;
	///<summary>A delegate that is invoked when the media metadata changed.</summary>
	public FOnMediaPlayerMediaEvent OnMetadataChanged;
	///<summary>Duration of samples to cache ahead of the play head.</summary>
	public FTimespan CacheAhead;
	///<summary>Duration of samples to cache behind the play head (when not running as game).</summary>
	public FTimespan CacheBehind;
	///<summary>Duration of samples to cache behind the play head (when running as game).</summary>
	public FTimespan CacheBehindGame;
	///<summary>Output any audio via the operating system&#39;s sound mixer instead of a Sound Wave asset.</summary>
	public bool NativeAudioOut;
	///<summary>Automatically start playback after media opened successfully.</summary>
	public bool PlayOnOpen;
	///<summary>Whether playback should shuffle media sources in the play list.</summary>
	public bool Shuffle;
	///<summary>Whether the player should loop when media playback reaches the end.</summary>
	public bool Loop;
	///<summary>The play list to use, if any.</summary>
	public UMediaPlaylist Playlist;
	///<summary>The current index of the source in the play list being played.</summary>
	public int PlaylistIndex;
	///<summary>Delay of the player&#39;s time.</summary>
	public FTimespan TimeDelay;
	///<summary>The initial horizontal field of view (in Euler degrees; default = 90).</summary>
	public float HorizontalFieldOfView;
	///<summary>The initial vertical field of view (in Euler degrees; default = 60).</summary>
	public float VerticalFieldOfView;
	///<summary>The initial view rotation.</summary>
	public FRotator ViewRotation;
	///<summary>The player&#39;s globally unique identifier.</summary>
	public FGuid PlayerGuid;
	///<summary>Whether this player should stop when entering or exiting PIE.</summary>
	public bool AffectedByPIEHandling;
}
