namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FAITestSpawnInfoBase</summary>
[CppInclude("FunctionalAITest.h")]
public partial struct FAITestSpawnInfoBase {
	public AActor SpawnLocation;
	public int NumberToSpawn;
	public float SpawnDelay;
	public float PreSpawnDelay;
}
