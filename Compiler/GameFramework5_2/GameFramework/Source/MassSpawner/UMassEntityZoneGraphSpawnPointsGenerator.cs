namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes the SpawnPoints Generator when we want to spawn directly on Zone Graph</summary>
[CppInclude("MassEntityZoneGraphSpawnPointsGenerator.h")]
public partial class UMassEntityZoneGraphSpawnPointsGenerator : UMassEntitySpawnDataGeneratorBase {
	public static UClass StaticClass() {return default;}
	///<summary>Tags to filter which lane to use to generate points on</summary>
	public FZoneGraphTagFilter TagFilter;
	///<summary>Minimum gap for spawning entities on a given lanes</summary>
	public float MinGap;
	///<summary>Minimum gap for spawning entities on a given lanes</summary>
	public float MaxGap;
}
