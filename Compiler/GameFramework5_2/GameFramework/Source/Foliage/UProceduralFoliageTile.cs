#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProceduralFoliageTile.h")]
///<summary>Procedurally determines where to spawn foliage meshes within a discrete area.</summary>
public partial class UProceduralFoliageTile : UObject {
// ProceduralFoliageTile
	public UProceduralFoliageSpawner FoliageSpawner;
	public TArray<FProceduralFoliageInstance> InstancesArray;
}
