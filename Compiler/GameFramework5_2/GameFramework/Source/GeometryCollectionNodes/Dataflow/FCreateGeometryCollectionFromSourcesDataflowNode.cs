#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>create a geometry collection from a set of geometry sources</summary>
[CppInclude("Dataflow/Nodes/GeometryCollectionAssetNodes.h")]
public partial struct FCreateGeometryCollectionFromSourcesDataflowNode {
	public TArray<FGeometryCollectionSource> Sources;
	public FManagedArrayCollection Collection;
	public TArray<UMaterial> Materials;
	public TArray<FGeometryCollectionAutoInstanceMesh> InstancedMeshes;
}
