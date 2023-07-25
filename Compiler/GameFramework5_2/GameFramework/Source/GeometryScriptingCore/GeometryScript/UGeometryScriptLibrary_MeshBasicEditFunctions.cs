#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBasicEditFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBasicEditFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshBasicEditFunctions
	public UObject DiscardMeshAttributes(UObject TargetMesh,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject SetVertexPosition(UObject TargetMesh,int VertexID,FVector NewPosition,bool bIsValidVertex,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject SetAllMeshVertexPositions(UObject TargetMesh,FGeometryScriptVectorList PositionList,UObject Debug/*=nullptr*/) { return default; }
	public UObject AddVertexToMesh(UObject TargetMesh,FVector NewPosition,int NewVertexIndex,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject AddVerticesToMesh(UObject TargetMesh,FGeometryScriptVectorList NewPositionsList,FGeometryScriptIndexList NewIndicesList,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject DeleteVertexFromMesh(UObject TargetMesh,int VertexID,bool bWasVertexDeleted,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject DeleteVerticesFromMesh(UObject TargetMesh,FGeometryScriptIndexList VertexList,int NumDeleted,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject AddTriangleToMesh(UObject TargetMesh,FIntVector NewTriangle,int NewTriangleIndex,int NewTriangleGroupID/*=0*/,bool bDeferChangeNotifications/*=false*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject AddTrianglesToMesh(UObject TargetMesh,FGeometryScriptTriangleList NewTrianglesList,FGeometryScriptIndexList NewIndicesList,int NewTriangleGroupID/*=0*/,bool bDeferChangeNotifications/*=false*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject DeleteTriangleFromMesh(UObject TargetMesh,int TriangleID,bool bWasTriangleDeleted,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject DeleteTrianglesFromMesh(UObject TargetMesh,FGeometryScriptIndexList TriangleList,int NumDeleted,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject DeleteSelectedTrianglesFromMesh(UObject TargetMesh,FGeometryScriptMeshSelection Selection,int NumDeleted,bool bDeferChangeNotifications/*=false*/) { return default; }
	public UObject AppendMesh(UObject TargetMesh,UObject AppendMesh,FTransform AppendTransform,bool bDeferChangeNotifications/*=false*/,FGeometryScriptAppendMeshOptions AppendOptions/*=new FGeometryScriptAppendMeshOptions()*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject AppendMeshTransformed(UObject TargetMesh,UObject AppendMesh,TArray<FTransform> AppendTransforms,FTransform ConstantTransform,bool bConstantTransformIsRelative/*=true*/,bool bDeferChangeNotifications/*=false*/,FGeometryScriptAppendMeshOptions AppendOptions/*=new FGeometryScriptAppendMeshOptions()*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject AppendMeshRepeated(UObject TargetMesh,UObject AppendMesh,FTransform AppendTransform,int RepeatCount/*=1*/,bool bApplyTransformToFirstInstance/*=true*/,bool bDeferChangeNotifications/*=false*/,FGeometryScriptAppendMeshOptions AppendOptions/*=new FGeometryScriptAppendMeshOptions()*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject AppendBuffersToMesh(UObject TargetMesh,FGeometryScriptSimpleMeshBuffers Buffers,FGeometryScriptIndexList NewTriangleIndicesList,int MaterialID/*=0*/,bool bDeferChangeNotifications/*=false*/,UObject Debug/*=nullptr*/) { return default; }
}
