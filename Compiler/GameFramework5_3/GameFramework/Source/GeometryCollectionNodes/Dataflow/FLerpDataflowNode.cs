namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linearly interpolates between A and B based on Alpha. (100% of A when Alpha = 0 and 100% of B when Alpha = 100)</summary>
[CppInclude("Dataflow/GeometryCollectionMathNodes.h")]
public partial struct FLerpDataflowNode {
	public float A;
	public float B;
	public float Alpha;
	public float ReturnValue;
}
