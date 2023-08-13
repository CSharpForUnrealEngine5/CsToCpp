namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the number of elements in an array</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FGetNumArrayElementsDataflowNode {
	public TArray<FVector> Points;
	public TArray<FVector3f> Vector3fArray;
	public int NumElements;
}
