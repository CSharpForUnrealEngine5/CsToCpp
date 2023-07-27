#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/SceneUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_SceneUtilityFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_SceneUtilityFunctions
	public static UDynamicMeshPool CreateDynamicMeshPool() { return default; }
	public static UDynamicMesh CopyMeshFromComponent(USceneComponent Component,UDynamicMesh ToDynamicMesh,FGeometryScriptCopyMeshFromComponentOptions Options,bool bTransformToWorld,FTransform LocalToWorld,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static void SetComponentMaterialList(UPrimitiveComponent Component,TArray<UMaterialInterface> MaterialList,UGeometryScriptDebug Debug/*=nullptr*/) {}
	public static UDynamicMesh CopyCollisionMeshesFromObject(UObject FromObject,UDynamicMesh ToDynamicMesh,bool bTransformToWorld,FTransform LocalToWorld,EGeometryScriptOutcomePins Outcome,bool bUseComplexCollision/*=false*/,int SphereResolution/*=16*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
