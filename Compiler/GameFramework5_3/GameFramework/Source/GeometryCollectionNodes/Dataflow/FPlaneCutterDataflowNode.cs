namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cuts geometry using a set of noised up planes</summary>
[CppInclude("Dataflow/GeometryCollectionFracturingNodes.h")]
public partial struct FPlaneCutterDataflowNode {
	public FManagedArrayCollection Collection;
	public FBox BoundingBox;
	public FDataflowTransformSelection TransformSelection;
	public int NumPlanes;
	public float RandomSeed;
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
