#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/SceneUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_SceneUtilityFunctions : UBlueprintFunctionLibrary {
	///<summary>Create a new UDynamicMeshPool object.</summary>
	public static UDynamicMeshPool CreateDynamicMeshPool() { return default; }
	///<summary>Copy the mesh from a given Component to a Dynamic Mesh.</summary>
	public static UDynamicMesh CopyMeshFromComponent(USceneComponent Component,UDynamicMesh ToDynamicMesh,FGeometryScriptCopyMeshFromComponentOptions Options,bool bTransformToWorld,FTransform LocalToWorld,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Configure the Material set on a PrimitiveComponent, by repeatedly calling SetMaterial.</summary>
	public static void SetComponentMaterialList(UPrimitiveComponent Component,TArray<UMaterialInterface> MaterialList,UGeometryScriptDebug Debug/*=nullptr*/) {}
	///<summary>Extract the Collision Geometry from FromObject and copy/approximate it with meshes stored in ToDynamicMesh.</summary>
	public static UDynamicMesh CopyCollisionMeshesFromObject(UObject FromObject,UDynamicMesh ToDynamicMesh,bool bTransformToWorld,FTransform LocalToWorld,EGeometryScriptOutcomePins Outcome,bool bUseComplexCollision/*=false*/,int SphereResolution/*=16*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
