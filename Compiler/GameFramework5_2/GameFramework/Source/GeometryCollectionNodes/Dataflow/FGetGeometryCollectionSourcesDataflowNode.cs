#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/Nodes/GeometryCollectionAssetNodes.h")]
///<summary>Get the list of the original mesh information used to create a specific geometryc collection asset</summary>
public partial struct FGetGeometryCollectionSourcesDataflowNode {
// GetGeometryCollectionSourcesDataflowNode
	public UGeometryCollection Asset;
	public TArray<FGeometryCollectionSource> Sources;
}
