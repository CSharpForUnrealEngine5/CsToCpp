#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshPolygroupFunctions.h")]
public partial class UGeometryScriptLibrary_MeshPolygroupFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshPolygroupFunctions
	public UObject EnablePolygroups(UObject TargetMesh,UObject Debug/*=nullptr*/) { return default; }
	public UObject SetNumExtendedPolygroupLayers(UObject TargetMesh,int NumLayers,UObject Debug/*=nullptr*/) { return default; }
	public UObject ClearPolygroups(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,int ClearValue/*=0*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject CopyPolygroupsLayer(UObject TargetMesh,FGeometryScriptGroupLayer FromGroupLayer,FGeometryScriptGroupLayer ToGroupLayer,UObject Debug/*=nullptr*/) { return default; }
	public UObject ConvertUVIslandsToPolygroups(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,int UVLayer/*=0*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject ConvertComponentsToPolygroups(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,UObject Debug/*=nullptr*/) { return default; }
	public UObject ComputePolygroupsFromAngleThreshold(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,float CreaseAngle/*=15f*/,int MinGroupSize/*=2*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject ComputePolygroupsFromPolygonDetection(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,bool bRespectUVSeams/*=true*/,bool bRespectHardNormals/*=false*/,double QuadAdjacencyWeight/*=1.0*/,double QuadMetricClamp/*=1.0*/,int MaxSearchRounds/*=1*/,UObject Debug/*=nullptr*/) { return default; }
	public int GetTrianglePolygroupID(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,int TriangleID,bool bIsValidTriangle) { return default; }
	public UObject DeleteTrianglesInPolygroup(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,int PolygroupID,int NumDeleted,bool bDeferChangeNotifications/*=false*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject GetAllTrianglePolygroupIDs(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,FGeometryScriptIndexList PolygroupIDsOut) { return default; }
	public UObject GetPolygroupIDsInMesh(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,FGeometryScriptIndexList PolygroupIDsOut) { return default; }
	public UObject GetTrianglesInPolygroup(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,int PolygroupID,FGeometryScriptIndexList TriangleIDsOut) { return default; }
	public UObject SetPolygroupForMeshSelection(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,FGeometryScriptMeshSelection Selection,int SetPolygroupIDOut,int SetPolygroupID/*=0*/,bool bGenerateNewPolygroup/*=false*/,bool bDeferChangeNotifications/*=false*/) { return default; }
}
