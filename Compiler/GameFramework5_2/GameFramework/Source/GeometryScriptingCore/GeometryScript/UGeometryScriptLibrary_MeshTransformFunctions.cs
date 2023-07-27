#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshTransformFunctions.h")]
public partial class UGeometryScriptLibrary_MeshTransformFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshTransformFunctions
	public static UDynamicMesh TransformMesh(UDynamicMesh TargetMesh,FTransform Transform,bool bFixOrientationForNegativeScale/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh TranslateMesh(UDynamicMesh TargetMesh,FVector Translation,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RotateMesh(UDynamicMesh TargetMesh,FRotator Rotation,FVector RotationOrigin/*=new FVector(0,0,0)*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ScaleMesh(UDynamicMesh TargetMesh,FVector Scale/*=new FVector(1,1,1)*/,FVector ScaleOrigin/*=new FVector(0,0,0)*/,bool bFixOrientationForNegativeScale/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh TransformMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FTransform Transform,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh TranslateMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FVector Translation,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RotateMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FRotator Rotation,FVector RotationOrigin/*=new FVector(0,0,0)*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ScaleMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FVector Scale/*=new FVector(1,1,1)*/,FVector ScaleOrigin/*=new FVector(0,0,0)*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh TranslatePivotToLocation(UDynamicMesh TargetMesh,FVector PivotLocation,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
