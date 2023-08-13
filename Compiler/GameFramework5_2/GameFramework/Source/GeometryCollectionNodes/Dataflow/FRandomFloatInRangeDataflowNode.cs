namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a random float between Min and Max</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FRandomFloatInRangeDataflowNode {
	public bool bDeterministic;
	public float RandomSeed;
	public float Min;
	public float Max;
	public float Float;
}
