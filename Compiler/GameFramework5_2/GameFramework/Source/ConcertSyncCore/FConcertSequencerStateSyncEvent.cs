#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSequencerMessages.h")]
///<summary>Event that represent the current open sequencer states to a newly connected client</summary>
public partial struct FConcertSequencerStateSyncEvent {
// ConcertSequencerStateSyncEvent
	public TArray<FConcertSequencerState> SequencerStates;
}
