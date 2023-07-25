#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/SceneUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_SceneUtilityFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_SceneUtilityFunctions
	public UObject CreateDynamicMeshPool() { return default; }
	public UObject CopyMeshFromComponent(UObject Component,UObject ToDynamicMesh,FGeometryScriptCopyMeshFromComponentOptions Options,bool bTransformToWorld,FTransform LocalToWorld,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
	public void SetComponentMaterialList(UObject Component,TArray<UObject> MaterialList,UObject Debug/*=nullptr*/) {}
	public UObject CopyCollisionMeshesFromObject(UObject FromObject,UObject ToDynamicMesh,bool bTransformToWorld,FTransform LocalToWorld,EGeometryScriptOutcomePins Outcome,bool bUseComplexCollision/*=false*/,int SphereResolution/*=16*/,UObject Debug/*=nullptr*/) { return default; }
}
