#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassSpawnerTypes.h")]
///<summary>Describes an entity type to spawn.</summary>
public partial struct FMassSpawnedEntityType {
// MassSpawnedEntityType
	public TSoftObjectPtr<UMassEntityConfigAsset> EntityConfig;
	public float Proportion;
	public UMassEntityConfigAsset EntityConfigPtr;
}
