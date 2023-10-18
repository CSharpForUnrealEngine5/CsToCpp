namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event that represent the current open sequencer states to a newly connected client</summary>
[CppInclude("ConcertSequencerMessages.h")]
public partial struct FConcertSequencerStateSyncEvent {
	public TArray<FConcertSequencerState> SequencerStates;
}
