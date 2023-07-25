#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionObject.h")]
public partial struct FGeometryCollectionSource {
// GeometryCollectionSource
	public FSoftObjectPath SourceGeometryObject;
	public FTransform LocalTransform;
	public TArray<UMaterialInterface> SourceMaterial;
	public bool bAddInternalMaterials;
	public bool bSplitComponents;
}
