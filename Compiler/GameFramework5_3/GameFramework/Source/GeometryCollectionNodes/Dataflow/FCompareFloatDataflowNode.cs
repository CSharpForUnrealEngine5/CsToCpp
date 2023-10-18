namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Comparison between floats</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FCompareFloatDataflowNode {
	public ECompareOperationEnum Operation;
	public float FloatA;
	public float FloatB;
	public bool Result;
}
