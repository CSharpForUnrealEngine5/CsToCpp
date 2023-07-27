#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CollisionFunctions.h")]
public partial class UGeometryScriptLibrary_CollisionFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_CollisionFunctions
	public static UDynamicMesh SetStaticMeshCollisionFromMesh(UDynamicMesh FromDynamicMesh,UStaticMesh ToStaticMeshAsset,FGeometryScriptCollisionFromMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static void SetStaticMeshCollisionFromComponent(UStaticMesh StaticMeshAsset,UPrimitiveComponent SourceComponent,FGeometryScriptSetSimpleCollisionOptions Options/*=new FGeometryScriptSetSimpleCollisionOptions()*/,UGeometryScriptDebug Debug/*=nullptr*/) {}
	public static UDynamicMesh SetDynamicMeshCollisionFromMesh(UDynamicMesh FromDynamicMesh,UDynamicMeshComponent ToDynamicMeshComponent,FGeometryScriptCollisionFromMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static void ResetDynamicMeshCollision(UDynamicMeshComponent Component,bool bEmitTransaction/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) {}
}
