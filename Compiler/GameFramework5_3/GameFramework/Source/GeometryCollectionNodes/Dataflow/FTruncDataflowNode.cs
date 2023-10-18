namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a float to the nearest integer. Rounds up when the fraction is .5</summary>
[CppInclude("Dataflow/GeometryCollectionMathNodes.h")]
public partial struct FTruncDataflowNode {
	public float Float;
	public float ReturnValue;
}
