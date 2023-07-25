#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
///<summary>Normalize all the selected vectors in a VectorArray</summary>
public partial struct FVectorArrayNormalizeDataflowNode {
// VectorArrayNormalizeDataflowNode
	public TArray<FVector> InVectorArray;
	public FDataflowVertexSelection Selection;
	public float Magnitude;
	public TArray<FVector> OutVectorArray;
}
