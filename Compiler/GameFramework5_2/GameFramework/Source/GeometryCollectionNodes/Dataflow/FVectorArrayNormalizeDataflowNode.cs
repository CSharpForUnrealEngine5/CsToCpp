namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Normalize all the selected vectors in a VectorArray</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FVectorArrayNormalizeDataflowNode {
	public TArray<FVector> InVectorArray;
	public FDataflowVertexSelection Selection;
	public float Magnitude;
	public TArray<FVector> OutVectorArray;
}
