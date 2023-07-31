#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
