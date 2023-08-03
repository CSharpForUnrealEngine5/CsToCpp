#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source that detects actors spawned close to the current camera, and captures them as spawnables</summary>
[CppInclude("TakeRecorderNearbySpawnedActorSource.h")]
public partial class UTakeRecorderNearbySpawnedActorSource : UTakeRecorderSource {
	public static UClass StaticClass() {return default;}
	///<summary>The proximity to the current camera that an actor must be spawned in order to be recorded as a spawnable. If 0, proximity is disregarded.</summary>
	public float Proximity;
	///<summary>Should we only record actors that pass the filter list?</summary>
	public bool bFilterSpawnedActors;
	///<summary>A type filter to apply to spawned objects</summary>
	public TArray<UClass> FilterTypes;
}
