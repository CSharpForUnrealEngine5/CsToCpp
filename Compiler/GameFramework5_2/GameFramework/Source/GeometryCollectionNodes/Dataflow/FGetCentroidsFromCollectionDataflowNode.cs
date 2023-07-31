#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gets centroids of pieces from a Collection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FGetCentroidsFromCollectionDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowTransformSelection TransformSelection;
	public TArray<FVector> Centroids;
}
