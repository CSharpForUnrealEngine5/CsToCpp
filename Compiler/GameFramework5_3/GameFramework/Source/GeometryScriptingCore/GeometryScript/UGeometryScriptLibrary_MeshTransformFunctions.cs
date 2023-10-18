namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshTransformFunctions.h")]
public partial class UGeometryScriptLibrary_MeshTransformFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Applies the provided Transform to the vertices of a Mesh.</summary>
	public static UDynamicMesh TransformMesh(UDynamicMesh TargetMesh,FTransform Transform,bool bFixOrientationForNegativeScale/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Applies the provided Translation to the vertices of a Mesh.</summary>
	public static UDynamicMesh TranslateMesh(UDynamicMesh TargetMesh,FVector Translation,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Rotates the mesh relative to the specified Rotation Origin.</summary>
	public static UDynamicMesh RotateMesh(UDynamicMesh TargetMesh,FRotator Rotation,FVector RotationOrigin/*=new FVector(0,0,0)*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Applies the provided Scale transformation relative to the Scale Origin to the vertices of a Mesh.</summary>
	public static UDynamicMesh ScaleMesh(UDynamicMesh TargetMesh,FVector Scale/*=new FVector(1,1,1)*/,FVector ScaleOrigin/*=new FVector(0,0,0)*/,bool bFixOrientationForNegativeScale/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Applies the given Transform to the vertices identified by the Selection of the mesh.</summary>
	public static UDynamicMesh TransformMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FTransform Transform,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Applies the given Translation to the vertices identified by the Selection of the mesh.</summary>
	public static UDynamicMesh TranslateMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FVector Translation,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Rotates the selected part of the mesh relative to the specified Rotation Origin.</summary>
	public static UDynamicMesh RotateMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FRotator Rotation,FVector RotationOrigin/*=new FVector(0,0,0)*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Applies the given Scale transform relative to the Scale Origin to the selection part of the mesh.</summary>
	public static UDynamicMesh ScaleMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FVector Scale/*=new FVector(1,1,1)*/,FVector ScaleOrigin/*=new FVector(0,0,0)*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Set the Pivot Location for the Mesh. Since the Pivot of a Mesh object is always the point at (0,0,0),</summary>
	public static UDynamicMesh TranslatePivotToLocation(UDynamicMesh TargetMesh,FVector PivotLocation,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
