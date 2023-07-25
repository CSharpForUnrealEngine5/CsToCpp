#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>The network role of an actor on a local/remote network context</summary>
public enum ENetRole {
	ROLE_None=0,
	ROLE_SimulatedProxy=1,
	ROLE_AutonomousProxy=2,
	ROLE_Authority=3,
	ROLE_MAX=4,
}
