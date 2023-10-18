namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event that signals a Sequencer just been opened.</summary>
[CppInclude("ConcertSequencerMessages.h")]
public partial struct FConcertSequencerOpenEvent {
	public string SequenceObjectPath;
	public FConcertByteArray TakeData;
}
