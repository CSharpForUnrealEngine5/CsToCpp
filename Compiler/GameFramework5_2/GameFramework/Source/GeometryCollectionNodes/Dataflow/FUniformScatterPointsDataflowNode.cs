#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
