#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFracturingNodes.h")]
///<summary>Cuts geometry using a set of noised up planes</summary>
public partial struct FPlaneCutterDataflowNode {
// PlaneCutterDataflowNode
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
