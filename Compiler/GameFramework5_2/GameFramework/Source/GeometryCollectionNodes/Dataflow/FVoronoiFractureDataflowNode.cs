#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFracturingNodes.h")]
///<summary>Generates a Voronoi fracture</summary>
public partial struct FVoronoiFractureDataflowNode {
// VoronoiFractureDataflowNode
	public FManagedArrayCollection Collection;
	public TArray<FVector> Points;
	public FDataflowTransformSelection TransformSelection;
	public float RandomSeed;
	public float ChanceToFracture;
	public bool GroupFracture;
	public float Grout;
	public float Amplitude;
	public float Frequency;
	public float Persistence;
	public float Lacunarity;
	public int OctaveNumber;
	public float PointSpacing;
	public bool AddSamplesForCollision;
	public float CollisionSampleSpacing;
}
