#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassActorSpawnerSubsystem.h")]
public enum ESpawnRequestStatus {
	None=0,
	Pending=1,
	Processing=2,
	Succeeded=3,
	Failed=4,
	RetryPending=5,
}
