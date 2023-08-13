namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/Actor.h")]
///<summary>Chooses a method for actors to update overlap state (objects it is touching) on initialization, currently only used during level streaming.</summary>
public enum EActorUpdateOverlapsMethod {
	UseConfigDefault=0,
	AlwaysUpdate=1,
	OnlyUpdateMovable=2,
	NeverUpdate=3,
}
