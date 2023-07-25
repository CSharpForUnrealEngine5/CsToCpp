#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshNormalsFunctions.h")]
public partial class UGeometryScriptLibrary_MeshNormalsFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshNormalsFunctions
	public UObject FlipNormals(UObject TargetMesh,UObject Debug/*=nullptr*/) { return default; }
	public UObject AutoRepairNormals(UObject TargetMesh,UObject Debug/*=nullptr*/) { return default; }
	public UObject SetPerVertexNormals(UObject TargetMesh,UObject Debug/*=nullptr*/) { return default; }
	public UObject SetPerFaceNormals(UObject TargetMesh,UObject Debug/*=nullptr*/) { return default; }
	public UObject RecomputeNormals(UObject TargetMesh,FGeometryScriptCalculateNormalsOptions CalculateOptions,UObject Debug/*=nullptr*/) { return default; }
	public UObject ComputeSplitNormals(UObject TargetMesh,FGeometryScriptSplitNormalsOptions SplitOptions,FGeometryScriptCalculateNormalsOptions CalculateOptions,UObject Debug/*=nullptr*/) { return default; }
	public UObject SetMeshTriangleNormals(UObject TargetMesh,int TriangleID,FGeometryScriptTriangle Normals,bool bIsValidTriangle,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject SetMeshPerVertexNormals(UObject TargetMesh,FGeometryScriptVectorList VertexNormalList,UObject Debug/*=nullptr*/) { return default; }
	public UObject GetMeshPerVertexNormals(UObject TargetMesh,FGeometryScriptVectorList NormalList,bool bIsValidNormalSet,bool bHasVertexIDGaps,bool bAverageSplitVertexValues/*=true*/) { return default; }
	public UObject GetMeshHasTangents(UObject TargetMesh,bool bHasTangents,UObject Debug/*=nullptr*/) { return default; }
	public UObject DiscardTangents(UObject TargetMesh,UObject Debug/*=nullptr*/) { return default; }
	public UObject ComputeTangents(UObject TargetMesh,FGeometryScriptTangentsOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject SetMeshPerVertexTangents(UObject TargetMesh,FGeometryScriptVectorList TangentXList,FGeometryScriptVectorList TangentYList,UObject Debug/*=nullptr*/) { return default; }
	public UObject GetMeshPerVertexTangents(UObject TargetMesh,FGeometryScriptVectorList TangentXList,FGeometryScriptVectorList TangentYList,bool bIsValidTangentSet,bool bHasVertexIDGaps,bool bAverageSplitVertexValues/*=true*/) { return default; }
	public UObject UpdateVertexNormal(UObject TargetMesh,int VertexID,bool bUpdateNormal,FVector NewNormal,bool bUpdateTangents,FVector NewTangentX,FVector NewTangentY,bool bIsValidVertex,bool bMergeSplitValues,bool bDeferChangeNotifications/*=false*/) { return default; }
}
