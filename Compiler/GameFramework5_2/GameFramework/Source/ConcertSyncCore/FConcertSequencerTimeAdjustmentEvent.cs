#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An event that represents a time changes on the sequencer. This can happen via take recorder</summary>
[CppInclude("ConcertSequencerMessages.h")]
public partial struct FConcertSequencerTimeAdjustmentEvent {
	public FFrameNumber PlaybackStartFrame;
	public string SequenceObjectPath;
}
