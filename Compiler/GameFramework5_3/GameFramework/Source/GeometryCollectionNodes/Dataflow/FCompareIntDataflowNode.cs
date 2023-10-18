namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Comparison between integers</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FCompareIntDataflowNode {
	public ECompareOperationEnum Operation;
	public int IntA;
	public int IntB;
	public bool Result;
}
