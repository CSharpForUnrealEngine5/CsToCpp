namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Specifies if an AI pawn will automatically be possessed by an AI controller</summary>
public enum EAutoPossessAI {
	Disabled=0,
	PlacedInWorld=1,
	Spawned=2,
	PlacedInWorldOrSpawned=3,
}
