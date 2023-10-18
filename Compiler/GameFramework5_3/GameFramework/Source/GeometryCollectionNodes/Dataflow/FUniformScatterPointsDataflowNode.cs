namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionFracturingNodes.h")]
public partial struct FUniformScatterPointsDataflowNode {
	public int MinNumberOfPoints;
	public int MaxNumberOfPoints;
	public float RandomSeed;
	public FBox BoundingBox;
	public TArray<FVector> Points;
}
