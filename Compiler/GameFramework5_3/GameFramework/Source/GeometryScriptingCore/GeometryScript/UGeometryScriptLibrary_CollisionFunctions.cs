namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CollisionFunctions.h")]
public partial class UGeometryScriptLibrary_CollisionFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Generates Simple Collision shapes for a Static Mesh Asset based on the input Dynamic Mesh.</summary>
	public static UDynamicMesh SetStaticMeshCollisionFromMesh(UDynamicMesh FromDynamicMesh,UStaticMesh ToStaticMeshAsset,FGeometryScriptCollisionFromMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Copy the Simple Collision Geometry from the Source Component to the Static Mesh Asset.</summary>
	public static void SetStaticMeshCollisionFromComponent(UStaticMesh StaticMeshAsset,UPrimitiveComponent SourceComponent,FGeometryScriptSetSimpleCollisionOptions Options/*=new FGeometryScriptSetSimpleCollisionOptions()*/,UGeometryScriptDebug Debug/*=nullptr*/) {}
	///<summary>Generate Simple Collision shapes for a Dynamic Mesh Component based on the input Dynamic Mesh.</summary>
	public static UDynamicMesh SetDynamicMeshCollisionFromMesh(UDynamicMesh FromDynamicMesh,UDynamicMeshComponent ToDynamicMeshComponent,FGeometryScriptCollisionFromMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Clears Simple Collisions from the Dynamic Mesh Component.</summary>
	public static void ResetDynamicMeshCollision(UDynamicMeshComponent Component,bool bEmitTransaction/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) {}
}
