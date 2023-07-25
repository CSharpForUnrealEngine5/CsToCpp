#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProceduralFoliageSpawner.h")]
public partial class UProceduralFoliageSpawner : UObject {
// ProceduralFoliageSpawner
	public int RandomSeed;
	public float TileSize;
	public int NumUniqueTiles;
	public float MinimumQuadTreeSize;
	public TArray<FFoliageTypeObject> FoliageTypes;
	public void Simulate(int NumSteps/*=-1*/) {}
}
