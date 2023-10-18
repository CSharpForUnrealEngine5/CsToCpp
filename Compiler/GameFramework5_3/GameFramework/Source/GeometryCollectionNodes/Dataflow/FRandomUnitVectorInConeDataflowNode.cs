namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution</summary>
[CppInclude("Dataflow/GeometryCollectionMathNodes.h")]
public partial struct FRandomUnitVectorInConeDataflowNode {
	public bool bDeterministic;
	public float RandomSeed;
	public FVector ConeDirection;
	public float ConeHalfAngle;
	public FVector ReturnValue;
}
