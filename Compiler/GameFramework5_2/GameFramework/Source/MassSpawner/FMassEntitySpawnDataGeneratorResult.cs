namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The result of the spawn point generator.</summary>
[CppInclude("MassEntitySpawnDataGeneratorBase.h")]
public partial struct FMassEntitySpawnDataGeneratorResult {
	public FInstancedStruct SpawnData;
	public UClass SpawnDataProcessor;
	public TArray<UClass> PostSpawnProcessors;
	public int EntityConfigIndex;
	public int NumEntities;
}
