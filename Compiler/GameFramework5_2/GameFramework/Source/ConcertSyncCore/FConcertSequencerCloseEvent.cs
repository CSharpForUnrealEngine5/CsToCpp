#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSequencerMessages.h")]
///<summary>Event that signals a Sequencer just been closed.</summary>
public partial struct FConcertSequencerCloseEvent {
// ConcertSequencerCloseEvent
	public string SequenceObjectPath;
	public bool bControllerClose;
	public int EditorsWithSequencerOpened;
}
