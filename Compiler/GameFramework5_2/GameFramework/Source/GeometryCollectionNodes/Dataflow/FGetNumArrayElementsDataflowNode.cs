#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the number of elements in an array</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FGetNumArrayElementsDataflowNode {
	public TArray<FVector> Points;
	public TArray<FVector3f> Vector3fArray;
	public int NumElements;
}
