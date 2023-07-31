#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Defines available strategies for handling the case where an actor is spawned in such a way that it penetrates blocking collision.</summary>
public enum ESpawnActorCollisionHandlingMethod {
	Undefined=0,
	AlwaysSpawn=1,
	AdjustIfPossibleButAlwaysSpawn=2,
	AdjustIfPossibleButDontSpawnIfColliding=3,
	DontSpawnIfColliding=4,
}
