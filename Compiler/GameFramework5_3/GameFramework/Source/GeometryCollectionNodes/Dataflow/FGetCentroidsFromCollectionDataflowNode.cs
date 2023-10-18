namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gets centroids of pieces from a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FGetCentroidsFromCollectionDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public TArray<FVector> Centroids;
}
