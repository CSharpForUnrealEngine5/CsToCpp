namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerPlaylistItem.h")]
public partial class USequencerPlaylistItem : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Number of frames by which to clip the in point of sections played from this item. Will also affect the first frame for hold.</summary>
	public int StartFrameOffset;
	///<summary>Number of frames by which to clip the out point of sections played from this item.</summary>
	public int EndFrameOffset;
	///<summary>If true, the sequence will be inserted immediately on recording start and any time Reset()</summary>
	public bool bHoldAtFirstFrame;
	///<summary>0 is single playthrough, &gt;= 1 is (n+1) playthroughs.</summary>
	public int NumLoops;
	///<summary>Speed multiplier at which to play sections created by this item. A value of 1 will result in playback at the original speed.</summary>
	public float PlaybackSpeed;
	///<summary>Disable playback of this item and prevent it from entering a hold state.</summary>
	public bool bMute;
}
