#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshTransformFunctions.h")]
public partial class UGeometryScriptLibrary_MeshTransformFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshTransformFunctions
	public UObject TransformMesh(UObject TargetMesh,FTransform Transform,bool bFixOrientationForNegativeScale/*=true*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject TranslateMesh(UObject TargetMesh,FVector Translation,UObject Debug/*=nullptr*/) { return default; }
	public UObject RotateMesh(UObject TargetMesh,FRotator Rotation,FVector RotationOrigin/*=new FVector(0,0,0)*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject ScaleMesh(UObject TargetMesh,FVector Scale/*=new FVector(1,1,1)*/,FVector ScaleOrigin/*=new FVector(0,0,0)*/,bool bFixOrientationForNegativeScale/*=true*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject TransformMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FTransform Transform,UObject Debug/*=nullptr*/) { return default; }
	public UObject TranslateMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FVector Translation,UObject Debug/*=nullptr*/) { return default; }
	public UObject RotateMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FRotator Rotation,FVector RotationOrigin/*=new FVector(0,0,0)*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject ScaleMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FVector Scale/*=new FVector(1,1,1)*/,FVector ScaleOrigin/*=new FVector(0,0,0)*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject TranslatePivotToLocation(UObject TargetMesh,FVector PivotLocation,UObject Debug/*=nullptr*/) { return default; }
}
