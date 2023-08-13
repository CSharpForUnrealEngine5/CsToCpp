namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionObject.h")]
public partial struct FGeometryCollectionSource {
	public FSoftObjectPath SourceGeometryObject;
	public FTransform LocalTransform;
	public TArray<UMaterialInterface> SourceMaterial;
	public bool bAddInternalMaterials;
	public bool bSplitComponents;
}
