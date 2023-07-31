#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperFlipbookComponent.h")]
public partial class UPaperFlipbookComponent : UMeshComponent {
	///<summary>Flipbook currently being played</summary>
	public UPaperFlipbook SourceFlipbook;
	///<summary>DEPRECATED in 4.5: The material override for this flipbook component (if any); replaced by the Materials array inherited from UMeshComponent</summary>
	public UMaterialInterface Material_DEPRECATED;
	///<summary>Current play rate of the flipbook</summary>
	public float PlayRate;
	///<summary>Whether the flipbook should loop when it reaches the end, or stop</summary>
	public bool bLooping;
	///<summary>If playback should move the current position backwards instead of forwards</summary>
	public bool bReversePlayback;
	///<summary>Are we currently playing (moving Position)</summary>
	public bool bPlaying;
	///<summary>Current position in the timeline</summary>
	public float AccumulatedTime;
	///<summary>Last frame index calculated</summary>
	public int CachedFrameIndex;
	///<summary>Vertex color to apply to the frames</summary>
	public FLinearColor SpriteColor;
	///<summary>The cached body setup</summary>
	public UBodySetup CachedBodySetup;
	///<summary>Event called whenever a non-looping flipbook finishes playing (either reaching the beginning or the end, depending on the play direction)</summary>
	public FFlipbookFinishedPlaySignature OnFinishedPlaying;
	///<summary>Change the flipbook used by this instance (will reset the play time to 0 if it is a new flipbook).</summary>
	public  bool SetFlipbook(UPaperFlipbook NewFlipbook) { return default; }
	///<summary>Gets the flipbook used by this instance.</summary>
	public  UPaperFlipbook GetFlipbook() { return default; }
	///<summary>Returns the current color of the sprite</summary>
	public  FLinearColor GetSpriteColor() { return default; }
	///<summary>Set color of the sprite</summary>
	public  void SetSpriteColor(FLinearColor NewColor) {}
	///<summary>Start playback of flipbook</summary>
	public  void Play() {}
	///<summary>Start playback of flipbook from the start</summary>
	public  void PlayFromStart() {}
	///<summary>Start playback of flipbook in reverse</summary>
	public  void Reverse() {}
	///<summary>Start playback of flipbook in reverse from the end</summary>
	public  void ReverseFromEnd() {}
	///<summary>Stop playback of flipbook</summary>
	public  void Stop() {}
	///<summary>Get whether this flipbook is playing or not.</summary>
	public  bool IsPlaying() { return default; }
	///<summary>Get whether we are reversing or not</summary>
	public  bool IsReversing() { return default; }
	///<summary>Jump to a position in the flipbook (expressed in frames). If bFireEvents is true, event functions will fire, otherwise they will not.</summary>
	public  void SetPlaybackPositionInFrames(int NewFramePosition,bool bFireEvents) {}
	///<summary>Get the current playback position (in frames) of the flipbook</summary>
	public  int GetPlaybackPositionInFrames() { return default; }
	///<summary>Jump to a position in the flipbook (expressed in seconds). If bFireEvents is true, event functions will fire, otherwise they will not.</summary>
	public  void SetPlaybackPosition(float NewPosition,bool bFireEvents) {}
	///<summary>Get the current playback position (in seconds) of the flipbook</summary>
	public  float GetPlaybackPosition() { return default; }
	///<summary>true means we should loop, false means we should not.</summary>
	public  void SetLooping(bool bNewLooping) {}
	///<summary>Get whether we are looping or not</summary>
	public  bool IsLooping() { return default; }
	///<summary>Sets the new play rate for this flipbook</summary>
	public  void SetPlayRate(float NewRate) {}
	///<summary>Get the current play rate for this flipbook</summary>
	public  float GetPlayRate() { return default; }
	///<summary>Set the new playback position time to use</summary>
	public  void SetNewTime(float NewTime) {}
	///<summary>Get length of the flipbook (in seconds)</summary>
	public  float GetFlipbookLength() { return default; }
	///<summary>Get length of the flipbook (in frames)</summary>
	public  int GetFlipbookLengthInFrames() { return default; }
	///<summary>Get the nominal framerate that the flipbook will be played back at (ignoring PlayRate), in frames per second</summary>
	public  float GetFlipbookFramerate() { return default; }
	///<summary>OnRep_SourceFlipbook</summary>
	public  void OnRep_SourceFlipbook(UPaperFlipbook OldFlipbook) {}
}
