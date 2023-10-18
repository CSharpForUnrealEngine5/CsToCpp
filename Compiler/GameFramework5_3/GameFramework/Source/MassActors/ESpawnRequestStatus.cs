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
