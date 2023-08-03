#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProceduralFoliageSpawner.h")]
public partial class UProceduralFoliageSpawner : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The seed used for generating the randomness of the simulation.</summary>
	public int RandomSeed;
	///<summary>Length of the tile (in cm) along one axis. The total area of the tile will be TileSize*TileSize.</summary>
	public float TileSize;
	///<summary>The number of unique tiles to generate. The final simulation is a procedurally determined combination of the various unique tiles.</summary>
	public int NumUniqueTiles;
	///<summary>Minimum size of the quad tree used during the simulation. Reduce if too many instances are in splittable leaf quads (as warned in the log).</summary>
	public float MinimumQuadTreeSize;
	///<summary>The types of foliage to procedurally spawn.</summary>
	public TArray<FFoliageTypeObject> FoliageTypes;
	///<summary>Simulate</summary>
	public  void Simulate(int NumSteps/*=-1*/) {}
}
