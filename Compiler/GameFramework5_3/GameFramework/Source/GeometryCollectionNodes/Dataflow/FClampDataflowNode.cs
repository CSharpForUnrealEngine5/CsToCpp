namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Clamps X to be between Min and Max, inclusive</summary>
[CppInclude("Dataflow/GeometryCollectionMathNodes.h")]
public partial struct FClampDataflowNode {
	public float Float;
	public float Min;
	public float Max;
	public float ReturnValue;
}
