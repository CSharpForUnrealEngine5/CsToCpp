#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSequencerMessages.h")]
///<summary>Enum for the current Sequencer player status, should match EMovieScenePlayerStatus::Type</summary>
public enum EConcertMovieScenePlayerStatus {
	Stopped=0,
	Playing=1,
	Scrubbing=2,
	Jumping=3,
	Stepping=4,
	Paused=5,
	MAX=6,
}
