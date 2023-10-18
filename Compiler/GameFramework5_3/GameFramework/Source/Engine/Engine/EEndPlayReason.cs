namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Specifies why an actor is being deleted/removed from a level</summary>
[CppEnumInNamespace]
public enum EEndPlayReason {
	Destroyed=0,
	LevelTransition=1,
	EndPlayInEditor=2,
	RemovedFromWorld=3,
	Quit=4,
}
