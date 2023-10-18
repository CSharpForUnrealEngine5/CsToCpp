namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a Voronoi fracture</summary>
[CppInclude("Dataflow/GeometryCollectionFracturingNodes.h")]
public partial struct FVoronoiFractureDataflowNode {
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
