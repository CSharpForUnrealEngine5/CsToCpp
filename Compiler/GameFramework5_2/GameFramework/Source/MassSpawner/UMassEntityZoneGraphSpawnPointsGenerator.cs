#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassEntityZoneGraphSpawnPointsGenerator.h")]
///<summary>Describes the SpawnPoints Generator when we want to spawn directly on Zone Graph</summary>
public partial class UMassEntityZoneGraphSpawnPointsGenerator : UMassEntitySpawnDataGeneratorBase {
// MassEntityZoneGraphSpawnPointsGenerator
	public FZoneGraphTagFilter TagFilter;
	public float MinGap;
	public float MaxGap;
}
