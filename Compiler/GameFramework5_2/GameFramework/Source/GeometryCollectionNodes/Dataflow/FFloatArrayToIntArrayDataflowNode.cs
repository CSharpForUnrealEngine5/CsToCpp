#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a Float array to Int array using the specified method.</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FFloatArrayToIntArrayDataflowNode {
	public EFloatArrayToIntArrayFunctionEnum Function;
	public TArray<float> FloatArray;
	public TArray<int> IntArray;
}
