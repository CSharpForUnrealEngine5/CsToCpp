#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution</summary>
public partial struct FRandomUnitVectorInConeDataflowNode {
// RandomUnitVectorInConeDataflowNode
	public bool bDeterministic;
	public float RandomSeed;
	public FVector ConeDirection;
	public float ConeHalfAngle;
	public FVector Vector;
}
