namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/Nodes/GeometryCollectionAssetNodes.h")]
public partial struct FGeometryCollectionTerminalDataflowNode {
	public FManagedArrayCollection Collection;
	public TArray<UMaterial> Materials;
	public TArray<FGeometryCollectionAutoInstanceMesh> InstancedMeshes;
}
