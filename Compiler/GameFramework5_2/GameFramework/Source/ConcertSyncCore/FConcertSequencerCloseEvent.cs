#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event that signals a Sequencer just been closed.</summary>
[CppInclude("ConcertSequencerMessages.h")]
public partial struct FConcertSequencerCloseEvent {
	public string SequenceObjectPath;
	public bool bControllerClose;
	public int EditorsWithSequencerOpened;
}
