#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakeRecorderNearbySpawnedActorSource.h")]
///<summary>A recording source that detects actors spawned close to the current camera, and captures them as spawnables</summary>
public partial class UTakeRecorderNearbySpawnedActorSource : UTakeRecorderSource {
// TakeRecorderNearbySpawnedActorSource
	public float Proximity;
	public bool bFilterSpawnedActors;
	public TArray<UClass> FilterTypes;
}
