namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshDecompositionFunctions.h")]
public partial class UGeometryScriptLibrary_MeshDecompositionFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new Mesh for each Connected Component of TargetMesh.</summary>
	public static UDynamicMesh SplitMeshByComponents(UDynamicMesh TargetMesh,TArray<UDynamicMesh> ComponentMeshes,UDynamicMeshPool MeshPool,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Create a new Mesh for each MaterialID of TargetMesh.</summary>
	public static UDynamicMesh SplitMeshByMaterialIDs(UDynamicMesh TargetMesh,TArray<UDynamicMesh> ComponentMeshes,TArray<int> ComponentMaterialIDs,UDynamicMeshPool MeshPool,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Create a new Mesh for each Polygroup of TargetMesh. Note that this may be a *large* number of meshes!</summary>
	public static UDynamicMesh SplitMeshByPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,TArray<UDynamicMesh> ComponentMeshes,TArray<int> ComponentPolygroups,UDynamicMeshPool MeshPool,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>CopyMeshSelectionToMesh should be used instead of this function</summary>
	public static UDynamicMesh GetSubMeshFromMesh(UDynamicMesh TargetMesh,UDynamicMesh StoreToSubmesh,FGeometryScriptIndexList TriangleList,UDynamicMesh StoreToSubmeshOut,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Extract the triangles identified by Selection from TargetMesh and copy/add them to StoreToSubmesh</summary>
	public static UDynamicMesh CopyMeshSelectionToMesh(UDynamicMesh TargetMesh,UDynamicMesh StoreToSubmesh,FGeometryScriptMeshSelection Selection,UDynamicMesh StoreToSubmeshOut,bool bAppendToExisting/*=false*/,bool bPreserveGroupIDs/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Set CopyToMesh to be the same mesh as CopyFromMesh</summary>
	public static UDynamicMesh CopyMeshToMesh(UDynamicMesh CopyFromMesh,UDynamicMesh CopyToMesh,UDynamicMesh CopyToMeshOut,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
