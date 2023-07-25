#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tracks/MovieSceneEventTrack.h")]
///<summary>Indicates at what point in the sequence evaluation events should fire</summary>
public enum EFireEventsAtPosition {
	AtStartOfEvaluation=0,
	AtEndOfEvaluation=1,
	AfterSpawn=2,
}
