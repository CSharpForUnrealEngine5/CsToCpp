namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Interfaces/OnlineTurnBasedInterface.h")]
///<summary>EMPMatchOutcome represents all the possible outcomes for this player in a match</summary>
public enum EMPMatchOutcome {
	None=0,
	Quit=1,
	Won=2,
	Lost=3,
	Tied=4,
	TimeExpired=5,
	First=6,
	Second=7,
	Third=8,
	Fourth=9,
}
