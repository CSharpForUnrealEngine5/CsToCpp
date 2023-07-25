#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
///<summary>Enumerates transition types.</summary>
public enum ETransitionType {
	None=0,
	Paused=1,
	Loading=2,
	Saving=3,
	Connecting=4,
	Precaching=5,
	WaitingToConnect=6,
	MAX=7,
}
