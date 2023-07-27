#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSelectionFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSelectionFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSelectionFunctions
	public static void GetMeshSelectionInfo(FGeometryScriptMeshSelection Selection,EGeometryScriptMeshSelectionType SelectionType,int NumSelected) {}
	public static void DebugPrintMeshSelection(FGeometryScriptMeshSelection Selection,bool bDisable/*=false*/) {}
	public static UDynamicMesh CreateSelectAllMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/) { return default; }
	public static UDynamicMesh ConvertMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection FromSelection,FGeometryScriptMeshSelection ToSelection,EGeometryScriptMeshSelectionType NewType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bAllowPartialInclusion/*=true*/) { return default; }
	public static void CombineMeshSelections(FGeometryScriptMeshSelection SelectionA,FGeometryScriptMeshSelection SelectionB,FGeometryScriptMeshSelection ResultSelection,EGeometryScriptCombineSelectionMode CombineMode/*=EGeometryScriptCombineSelectionMode.Add*/) {}
	public static UDynamicMesh ConvertIndexArrayToMeshSelection(UDynamicMesh TargetMesh,TArray<int> IndexArray,EGeometryScriptMeshSelectionType SelectionType,FGeometryScriptMeshSelection Selection) { return default; }
	public static UDynamicMesh ConvertIndexSetToMeshSelection(UDynamicMesh TargetMesh,TSet<int> IndexSet,EGeometryScriptMeshSelectionType SelectionType,FGeometryScriptMeshSelection Selection) { return default; }
	public static UDynamicMesh ConvertMeshSelectionToIndexArray(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,TArray<int> IndexArray,EGeometryScriptMeshSelectionType SelectionType) { return default; }
	public static UDynamicMesh ConvertIndexListToMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptIndexList IndexList,EGeometryScriptMeshSelectionType SelectionType,FGeometryScriptMeshSelection Selection) { return default; }
	public static UDynamicMesh ConvertMeshSelectionToIndexList(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptIndexList IndexList,EGeometryScriptIndexType ResultListType,EGeometryScriptIndexType ConvertToType/*=EGeometryScriptIndexType.Any*/) { return default; }
	public static UDynamicMesh SelectMeshElementsInBox(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FBox Box,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bInvert/*=false*/,int MinNumTrianglePoints/*=3*/) { return default; }
	public static UDynamicMesh SelectMeshElementsInSphere(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FVector SphereOrigin/*=FVector.ZeroVector*/,double SphereRadius/*=100.0*/,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bInvert/*=false*/,int MinNumTrianglePoints/*=3*/) { return default; }
	public static UDynamicMesh SelectMeshElementsWithPlane(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FVector PlaneOrigin/*=FVector.ZeroVector*/,FVector PlaneNormal/*=FVector.UpVector*/,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bInvert/*=false*/,int MinNumTrianglePoints/*=3*/) { return default; }
	public static UDynamicMesh SelectMeshElementsByNormalAngle(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FVector Normal/*=FVector.UpVector*/,double MaxAngleDeg/*=1.0*/,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bInvert/*=false*/,int MinNumTrianglePoints/*=3*/) { return default; }
	public static UDynamicMesh SelectMeshElementsInsideMesh(UDynamicMesh TargetMesh,UDynamicMesh SelectionMesh,FGeometryScriptMeshSelection Selection,FTransform SelectionMeshTransform,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bInvert/*=false*/,double ShellDistance/*=0.0*/,double WindingThreshold/*=0.5*/,int MinNumTrianglePoints/*=3*/) { return default; }
	public static UDynamicMesh InvertMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewSelection,bool bOnlyToConnected/*=false*/) { return default; }
	public static UDynamicMesh ExpandMeshSelectionToConnected(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewSelection,EGeometryScriptTopologyConnectionType ConnectionType/*=EGeometryScriptTopologyConnectionType.Geometric*/) { return default; }
	public static UDynamicMesh ExpandContractMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewSelection,int Iterations/*=1*/,bool bContract/*=false*/,bool bOnlyExpandToFaceNeighbours/*=false*/) { return default; }
}
