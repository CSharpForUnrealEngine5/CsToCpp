#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Specifies why an actor is being deleted/removed from a level</summary>
public enum EEndPlayReason {
	Destroyed=0,
	LevelTransition=1,
	EndPlayInEditor=2,
	RemovedFromWorld=3,
	Quit=4,
}
