#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RejoinCheck.h")]
///<summary>Possible states that a rejoin check can be in at any given time</summary>
public enum ERejoinStatus {
	NoMatchToRejoin=0,
	RejoinAvailable=1,
	UpdatingStatus=2,
	NeedsRecheck=3,
	NoMatchToRejoin_MatchEnded=4,
}
