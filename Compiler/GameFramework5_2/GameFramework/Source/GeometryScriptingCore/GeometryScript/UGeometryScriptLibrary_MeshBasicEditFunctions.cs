#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBasicEditFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBasicEditFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshBasicEditFunctions
	public static UDynamicMesh DiscardMeshAttributes(UDynamicMesh TargetMesh,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh SetVertexPosition(UDynamicMesh TargetMesh,int VertexID,FVector NewPosition,bool bIsValidVertex,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh SetAllMeshVertexPositions(UDynamicMesh TargetMesh,FGeometryScriptVectorList PositionList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh AddVertexToMesh(UDynamicMesh TargetMesh,FVector NewPosition,int NewVertexIndex,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh AddVerticesToMesh(UDynamicMesh TargetMesh,FGeometryScriptVectorList NewPositionsList,FGeometryScriptIndexList NewIndicesList,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh DeleteVertexFromMesh(UDynamicMesh TargetMesh,int VertexID,bool bWasVertexDeleted,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh DeleteVerticesFromMesh(UDynamicMesh TargetMesh,FGeometryScriptIndexList VertexList,int NumDeleted,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh AddTriangleToMesh(UDynamicMesh TargetMesh,FIntVector NewTriangle,int NewTriangleIndex,int NewTriangleGroupID/*=0*/,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh AddTrianglesToMesh(UDynamicMesh TargetMesh,FGeometryScriptTriangleList NewTrianglesList,FGeometryScriptIndexList NewIndicesList,int NewTriangleGroupID/*=0*/,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh DeleteTriangleFromMesh(UDynamicMesh TargetMesh,int TriangleID,bool bWasTriangleDeleted,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh DeleteTrianglesFromMesh(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleList,int NumDeleted,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh DeleteSelectedTrianglesFromMesh(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,int NumDeleted,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh AppendMesh(UDynamicMesh TargetMesh,UDynamicMesh AppendMesh,FTransform AppendTransform,bool bDeferChangeNotifications/*=false*/,FGeometryScriptAppendMeshOptions AppendOptions/*=new FGeometryScriptAppendMeshOptions()*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh AppendMeshTransformed(UDynamicMesh TargetMesh,UDynamicMesh AppendMesh,TArray<FTransform> AppendTransforms,FTransform ConstantTransform,bool bConstantTransformIsRelative/*=true*/,bool bDeferChangeNotifications/*=false*/,FGeometryScriptAppendMeshOptions AppendOptions/*=new FGeometryScriptAppendMeshOptions()*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh AppendMeshRepeated(UDynamicMesh TargetMesh,UDynamicMesh AppendMesh,FTransform AppendTransform,int RepeatCount/*=1*/,bool bApplyTransformToFirstInstance/*=true*/,bool bDeferChangeNotifications/*=false*/,FGeometryScriptAppendMeshOptions AppendOptions/*=new FGeometryScriptAppendMeshOptions()*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh AppendBuffersToMesh(UDynamicMesh TargetMesh,FGeometryScriptSimpleMeshBuffers Buffers,FGeometryScriptIndexList NewTriangleIndicesList,int MaterialID/*=0*/,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
