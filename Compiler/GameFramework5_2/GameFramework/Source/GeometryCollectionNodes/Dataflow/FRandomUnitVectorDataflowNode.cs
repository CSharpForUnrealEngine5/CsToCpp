#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns a random vector with length of 1</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FRandomUnitVectorDataflowNode {
	public bool bDeterministic;
	public float RandomSeed;
	public FVector Vector;
}
