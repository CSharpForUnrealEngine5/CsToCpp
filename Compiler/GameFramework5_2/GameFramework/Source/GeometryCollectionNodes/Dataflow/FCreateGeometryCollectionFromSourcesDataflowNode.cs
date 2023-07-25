#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/Nodes/GeometryCollectionAssetNodes.h")]
///<summary>create a geometry collection from a set of geometry sources</summary>
public partial struct FCreateGeometryCollectionFromSourcesDataflowNode {
// CreateGeometryCollectionFromSourcesDataflowNode
	public TArray<FGeometryCollectionSource> Sources;
	public FManagedArrayCollection Collection;
	public TArray<UMaterial> Materials;
	public TArray<FGeometryCollectionAutoInstanceMesh> InstancedMeshes;
}
