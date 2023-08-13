namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneFwd.h")]
///<summary>Enum used to define how to update to a particular time</summary>
public enum EUpdateClockSource {
	Tick=0,
	Platform=1,
	Audio=2,
	RelativeTimecode=3,
	Timecode=4,
	PlayEveryFrame=5,
	Custom=6,
}
