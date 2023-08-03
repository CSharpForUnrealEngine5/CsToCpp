#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSelectionFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSelectionFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Query information about a Mesh Selection</summary>
	public static void GetMeshSelectionInfo(FGeometryScriptMeshSelection Selection,EGeometryScriptMeshSelectionType SelectionType,int NumSelected) {}
	///<summary>Print information about the Mesh Selection to the Output Log</summary>
	public static void DebugPrintMeshSelection(FGeometryScriptMeshSelection Selection,bool bDisable/*=false*/) {}
	///<summary>Create a Selection of the given SelectionType that contains all the mesh elements of TargetMesh</summary>
	public static UDynamicMesh CreateSelectAllMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/) { return default; }
	///<summary>Convert a Mesh Selection to a different Type (eg Vertices to Triangles, etc)</summary>
	public static UDynamicMesh ConvertMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection FromSelection,FGeometryScriptMeshSelection ToSelection,EGeometryScriptMeshSelectionType NewType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bAllowPartialInclusion/*=true*/) { return default; }
	///<summary>Combine two Mesh Selections into a new Mesh Selection.</summary>
	public static void CombineMeshSelections(FGeometryScriptMeshSelection SelectionA,FGeometryScriptMeshSelection SelectionB,FGeometryScriptMeshSelection ResultSelection,EGeometryScriptCombineSelectionMode CombineMode/*=EGeometryScriptCombineSelectionMode.Add*/) {}
	///<summary>Create a Mesh Selection from the IndexArray.</summary>
	public static UDynamicMesh ConvertIndexArrayToMeshSelection(UDynamicMesh TargetMesh,TArray<int> IndexArray,EGeometryScriptMeshSelectionType SelectionType,FGeometryScriptMeshSelection Selection) { return default; }
	///<summary>Create a Mesh Selection from the IndexSet.</summary>
	public static UDynamicMesh ConvertIndexSetToMeshSelection(UDynamicMesh TargetMesh,TSet<int> IndexSet,EGeometryScriptMeshSelectionType SelectionType,FGeometryScriptMeshSelection Selection) { return default; }
	///<summary>Convert a Mesh Selection to an Index List</summary>
	public static UDynamicMesh ConvertMeshSelectionToIndexArray(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,TArray<int> IndexArray,EGeometryScriptMeshSelectionType SelectionType) { return default; }
	///<summary>Create a Mesh Selection from the Index List. For cases where the IndexList Type does not match</summary>
	public static UDynamicMesh ConvertIndexListToMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptIndexList IndexList,EGeometryScriptMeshSelectionType SelectionType,FGeometryScriptMeshSelection Selection) { return default; }
	///<summary>Convert a Mesh Selection to an Index List</summary>
	public static UDynamicMesh ConvertMeshSelectionToIndexList(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptIndexList IndexList,EGeometryScriptIndexType ResultListType,EGeometryScriptIndexType ConvertToType/*=EGeometryScriptIndexType.Any*/) { return default; }
	///<summary>Create a new Mesh Selection of the SelectionType for the TargetMesh by finding all elements contained in the Box.</summary>
	public static UDynamicMesh SelectMeshElementsInBox(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FBox Box,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bInvert/*=false*/,int MinNumTrianglePoints/*=3*/) { return default; }
	///<summary>Create a new Mesh Selection of the SelectionType for the TargetMesh by finding all elements contained in the Sphere.</summary>
	public static UDynamicMesh SelectMeshElementsInSphere(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FVector SphereOrigin/*=FVector.ZeroVector*/,double SphereRadius/*=100.0*/,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bInvert/*=false*/,int MinNumTrianglePoints/*=3*/) { return default; }
	///<summary>Create a new Mesh Selection of the SelectionType for the TargetMesh by finding all elements on the &quot;positive&quot; side of a Plane</summary>
	public static UDynamicMesh SelectMeshElementsWithPlane(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FVector PlaneOrigin/*=FVector.ZeroVector*/,FVector PlaneNormal/*=FVector.UpVector*/,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bInvert/*=false*/,int MinNumTrianglePoints/*=3*/) { return default; }
	///<summary>Create a new Mesh Selection of the SelectionType for the TargetMesh by finding all elements that have a normal</summary>
	public static UDynamicMesh SelectMeshElementsByNormalAngle(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FVector Normal/*=FVector.UpVector*/,double MaxAngleDeg/*=1.0*/,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bInvert/*=false*/,int MinNumTrianglePoints/*=3*/) { return default; }
	///<summary>Create a new Mesh Selection of the SelectionType for the TargetMesh by finding all elements inside a second SelectionMesh</summary>
	public static UDynamicMesh SelectMeshElementsInsideMesh(UDynamicMesh TargetMesh,UDynamicMesh SelectionMesh,FGeometryScriptMeshSelection Selection,FTransform SelectionMeshTransform,EGeometryScriptMeshSelectionType SelectionType/*=EGeometryScriptMeshSelectionType.Triangles*/,bool bInvert/*=false*/,double ShellDistance/*=0.0*/,double WindingThreshold/*=0.5*/,int MinNumTrianglePoints/*=3*/) { return default; }
	///<summary>Invert the Selection on the TargetMesh, ie select what is not currently selected</summary>
	public static UDynamicMesh InvertMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewSelection,bool bOnlyToConnected/*=false*/) { return default; }
	///<summary>Expand the Selection on the TargetMesh to connected regions and return the NewSelection</summary>
	public static UDynamicMesh ExpandMeshSelectionToConnected(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewSelection,EGeometryScriptTopologyConnectionType ConnectionType/*=EGeometryScriptTopologyConnectionType.Geometric*/) { return default; }
	///<summary>Grow or Shrink the Selection on the TargetMesh to connected neighbours.</summary>
	public static UDynamicMesh ExpandContractMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewSelection,int Iterations/*=1*/,bool bContract/*=false*/,bool bOnlyExpandToFaceNeighbours/*=false*/) { return default; }
}
