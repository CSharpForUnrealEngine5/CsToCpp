#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a media player asset that can play movies and other media.</summary>
[CppInclude("BinkMediaPlayer.h")]
public partial class UBinkMediaPlayer : UObject {
	///<summary>Checks whether media playback can be paused right now.</summary>
	public  bool CanPause() { return default; }
	///<summary>Checks whether media playback can be started right now.</summary>
	public  bool CanPlay() { return default; }
	///<summary>Gets the media&#39;s duration.</summary>
	public  FTimespan GetDuration() { return default; }
	///<summary>Gets the media&#39;s current playback rate.</summary>
	public  float GetRate() { return default; }
	///<summary>Gets the media&#39;s current playback time.</summary>
	public  FTimespan GetTime() { return default; }
	///<summary>Gets the URL of the currently loaded media, if any.</summary>
	public  string GetUrl() { return default; }
	///<summary>Checks whether playback is looping.</summary>
	public  bool IsLooping() { return default; }
	///<summary>Checks whether playback is currently paused.</summary>
	public  bool IsPaused() { return default; }
	///<summary>Checks whether playback has started.</summary>
	public  bool IsPlaying() { return default; }
	///<summary>Checks whether playback has stopped.</summary>
	public  bool IsStopped() { return default; }
	///<summary>Opens the specified media URL.</summary>
	public  bool OpenUrl(string NewUrl) { return default; }
	///<summary>Closes the specified media URL.</summary>
	public  void CloseUrl() {}
	///<summary>Pauses media playback.</summary>
	public  bool Pause() { return default; }
	///<summary>Starts media playback.</summary>
	public  bool Play() { return default; }
	///<summary>Rewinds the media to the beginning.</summary>
	public  bool Rewind() { return default; }
	///<summary>Seeks to the specified playback time.</summary>
	public  bool Seek(FTimespan InTime) { return default; }
	///<summary>Enables or disables playback looping.</summary>
	public  bool SetLooping(bool InLooping) { return default; }
	///<summary>Changes the media&#39;s playback rate.</summary>
	public  bool SetRate(float Rate) { return default; }
	///<summary>Changes the media&#39;s volume</summary>
	public  void SetVolume(float Rate) {}
	///<summary>Stops playback and unloads the video from memory. If you want to start the video again you&#39;ll need to call InitializePlayer.</summary>
	public  void Stop() {}
	///<summary>Checks whether the specified playback rate is supported.</summary>
	public  bool SupportsRate(float Rate,bool Unthinned) { return default; }
	///<summary>Checks whether the currently loaded media supports scrubbing.</summary>
	public  bool SupportsScrubbing() { return default; }
	///<summary>Checks whether the currently loaded media can jump to a certain position.</summary>
	public  bool SupportsSeeking() { return default; }
	///<summary>Checks whether this player has been initialized with a media source.</summary>
	public  bool IsInitialized() { return default; }
	///<summary>Draws this bink to the specified texture</summary>
	public  void Draw(UTexture texture,bool tonemap/*=false*/,int out_nits/*=10000*/,float alpha/*=1f*/,bool srgb_decode/*=false*/,bool hdr/*=false*/) {}
	///<summary>Holds a delegate that is invoked when a media source has been closed.</summary>
	public FOnBinkMediaPlayerMediaClosed OnMediaClosed;
	///<summary>Holds a delegate that is invoked when a media source has been opened.</summary>
	public FOnBinkMediaPlayerMediaOpened OnMediaOpened;
	///<summary>Holds a delegate that is invoked when a media source has been opened.</summary>
	public FOnBinkMediaPlayerMediaReachedEnd OnMediaReachedEnd;
	///<summary>A delegate that is invoked when media playback has been suspended.</summary>
	public FOnBinkMediaPlayerMediaEvent OnPlaybackSuspended;
	///<summary>Whether playback should loop when it reaches the end.</summary>
	public bool Looping;
	///<summary>Whether playback start immediately, or wait for blueprint to start it.</summary>
	public bool StartImmediately;
	///<summary>To reduce memory use, don&#39;t immediately open the bink until it is first played.</summary>
	public bool DelayedOpen;
	///<summary>Used to specify the sounds to open at playback.</summary>
	public FVector2D BinkDestinationUpperLeft;
	///<summary>Used to specify the sounds to open at playback.</summary>
	public FVector2D BinkDestinationLowerRight;
	///<summary>The path or URL to the media file to be played.</summary>
	public string URL;
	///<summary>Used to specify the how the video should be buffered.</summary>
	public EBinkMediaPlayerBinkBufferModes BinkBufferMode;
	///<summary>Used to specify the sounds to open at playback.</summary>
	public EBinkMediaPlayerBinkSoundTrack BinkSoundTrack;
	///<summary>Used to specify the sounds to open at playback.</summary>
	public int BinkSoundTrackStart;
	///<summary>Used to specify how the movie is drawn.</summary>
	public EBinkMediaPlayerBinkDrawStyle BinkDrawStyle;
	///<summary>Used to specify the render order.</summary>
	public int BinkLayerDepth;
}
