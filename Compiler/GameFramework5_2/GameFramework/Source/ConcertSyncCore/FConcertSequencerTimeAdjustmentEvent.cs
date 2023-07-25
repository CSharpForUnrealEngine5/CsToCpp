#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSequencerMessages.h")]
///<summary>An event that represents a time changes on the sequencer. This can happen via take recorder</summary>
public partial struct FConcertSequencerTimeAdjustmentEvent {
// ConcertSequencerTimeAdjustmentEvent
	public FFrameNumber PlaybackStartFrame;
	public string SequenceObjectPath;
}
