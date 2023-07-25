#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassEntitySpawnDataGeneratorBase.h")]
///<summary>The result of the spawn point generator.</summary>
public partial struct FMassEntitySpawnDataGeneratorResult {
// MassEntitySpawnDataGeneratorResult
	public FInstancedStruct SpawnData;
	public UClass SpawnDataProcessor;
	public TArray<UClass> PostSpawnProcessors;
	public int EntityConfigIndex;
	public int NumEntities;
}
