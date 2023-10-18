namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns Float normalized to the given range</summary>
[CppInclude("Dataflow/GeometryCollectionMathNodes.h")]
public partial struct FNormalizeToRangeDataflowNode {
	public float Float;
	public float RangeMin;
	public float RangeMax;
	public float ReturnValue;
}
