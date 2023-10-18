namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes an entity type to spawn.</summary>
[CppInclude("MassSpawnerTypes.h")]
public partial struct FMassSpawnedEntityType {
	public TSoftObjectPtr<UMassEntityConfigAsset> EntityConfig;
	public float Proportion;
	public UMassEntityConfigAsset EntityConfigPtr;
}
