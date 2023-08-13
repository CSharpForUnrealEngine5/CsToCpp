namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event that signals a Sequencer just been closed.</summary>
[CppInclude("ConcertSequencerMessages.h")]
public partial struct FConcertSequencerCloseEvent {
	public string SequenceObjectPath;
	public bool bControllerClose;
	public int EditorsWithSequencerOpened;
}
