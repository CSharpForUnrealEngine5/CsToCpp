#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CollisionFunctions.h")]
public partial class UGeometryScriptLibrary_CollisionFunctions : UBlueprintFunctionLibrary {
	///<summary>SetStaticMeshCollisionFromMesh</summary>
	public static UDynamicMesh SetStaticMeshCollisionFromMesh(UDynamicMesh FromDynamicMesh,UStaticMesh ToStaticMeshAsset,FGeometryScriptCollisionFromMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Copy the Simple Collision Geometry from the SourceComponent to the StaticMeshAsset</summary>
	public static void SetStaticMeshCollisionFromComponent(UStaticMesh StaticMeshAsset,UPrimitiveComponent SourceComponent,FGeometryScriptSetSimpleCollisionOptions Options/*=new FGeometryScriptSetSimpleCollisionOptions()*/,UGeometryScriptDebug Debug/*=nullptr*/) {}
	///<summary>SetDynamicMeshCollisionFromMesh</summary>
	public static UDynamicMesh SetDynamicMeshCollisionFromMesh(UDynamicMesh FromDynamicMesh,UDynamicMeshComponent ToDynamicMeshComponent,FGeometryScriptCollisionFromMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ResetDynamicMeshCollision</summary>
	public static void ResetDynamicMeshCollision(UDynamicMeshComponent Component,bool bEmitTransaction/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) {}
}
