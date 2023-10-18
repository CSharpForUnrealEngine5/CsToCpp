namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns a random vector with length of 1</summary>
[CppInclude("Dataflow/GeometryCollectionMathNodes.h")]
public partial struct FRandomUnitVectorDataflowNode {
	public bool bDeterministic;
	public float RandomSeed;
	public FVector ReturnValue;
}
