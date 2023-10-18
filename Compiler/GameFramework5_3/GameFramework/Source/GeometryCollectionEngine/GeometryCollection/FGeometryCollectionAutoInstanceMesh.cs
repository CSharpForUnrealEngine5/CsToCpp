namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionObject.h")]
public partial struct FGeometryCollectionAutoInstanceMesh {
	public FSoftObjectPath StaticMesh_DEPRECATED;
	public UStaticMesh Mesh;
	public TArray<UMaterialInterface> Materials;
	public int NumInstances;
	public TArray<float> CustomData;
}
