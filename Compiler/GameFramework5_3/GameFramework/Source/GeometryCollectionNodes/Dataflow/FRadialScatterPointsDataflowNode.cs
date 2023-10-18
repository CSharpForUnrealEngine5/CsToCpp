namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFracturingNodes.h")]
public partial struct FRadialScatterPointsDataflowNode {
	public FVector Center;
	public FVector Normal;
	public float Radius;
	public int AngularSteps;
	public int RadialSteps;
	public float AngleOffset;
	public float Variability;
	public float RandomSeed;
	public TArray<FVector> Points;
}
