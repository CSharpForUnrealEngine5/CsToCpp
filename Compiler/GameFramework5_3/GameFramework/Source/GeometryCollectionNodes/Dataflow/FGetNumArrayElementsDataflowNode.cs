namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the number of elements in an array</summary>
[CppInclude("Dataflow/GeometryCollectionArrayNodes.h")]
public partial struct FGetNumArrayElementsDataflowNode {
	public TArray<float> FloatArray;
	public TArray<int> IntArray;
	public TArray<FVector> Points;
	public TArray<FVector3f> Vector3fArray;
	public int NumElements;
}
