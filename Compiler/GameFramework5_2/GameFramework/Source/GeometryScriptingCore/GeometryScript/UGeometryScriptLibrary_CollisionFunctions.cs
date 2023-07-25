#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CollisionFunctions.h")]
public partial class UGeometryScriptLibrary_CollisionFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_CollisionFunctions
	public UObject SetStaticMeshCollisionFromMesh(UObject FromDynamicMesh,UObject ToStaticMeshAsset,FGeometryScriptCollisionFromMeshOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public void SetStaticMeshCollisionFromComponent(UObject StaticMeshAsset,UObject SourceComponent,FGeometryScriptSetSimpleCollisionOptions Options/*=new FGeometryScriptSetSimpleCollisionOptions()*/,UObject Debug/*=nullptr*/) {}
	public UObject SetDynamicMeshCollisionFromMesh(UObject FromDynamicMesh,UObject ToDynamicMeshComponent,FGeometryScriptCollisionFromMeshOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public void ResetDynamicMeshCollision(UObject Component,bool bEmitTransaction/*=false*/,UObject Debug/*=nullptr*/) {}
}
