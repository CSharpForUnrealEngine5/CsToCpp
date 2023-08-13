namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event that signals a sequencer UI has changed the current state</summary>
[CppInclude("ConcertSequencerMessages.h")]
public partial struct FConcertSequencerStateEvent {
	public FConcertSequencerState State;
}
