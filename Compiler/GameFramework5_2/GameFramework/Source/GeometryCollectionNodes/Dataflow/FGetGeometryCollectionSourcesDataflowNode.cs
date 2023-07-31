#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get the list of the original mesh information used to create a specific geometryc collection asset</summary>
[CppInclude("Dataflow/Nodes/GeometryCollectionAssetNodes.h")]
public partial struct FGetGeometryCollectionSourcesDataflowNode {
	public UGeometryCollection Asset;
	public TArray<FGeometryCollectionSource> Sources;
}
