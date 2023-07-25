#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshDecompositionFunctions.h")]
public partial class UGeometryScriptLibrary_MeshDecompositionFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshDecompositionFunctions
	public UObject SplitMeshByComponents(UObject TargetMesh,TArray<UObject> ComponentMeshes,UObject MeshPool,UObject Debug/*=nullptr*/) { return default; }
	public UObject SplitMeshByMaterialIDs(UObject TargetMesh,TArray<UObject> ComponentMeshes,TArray<int> ComponentMaterialIDs,UObject MeshPool,UObject Debug/*=nullptr*/) { return default; }
	public UObject SplitMeshByPolygroups(UObject TargetMesh,FGeometryScriptGroupLayer GroupLayer,TArray<UObject> ComponentMeshes,TArray<int> ComponentPolygroups,UObject MeshPool,UObject Debug/*=nullptr*/) { return default; }
	public UObject GetSubMeshFromMesh(UObject TargetMesh,UObject StoreToSubmesh,FGeometryScriptIndexList TriangleList,UObject StoreToSubmeshOut,UObject Debug/*=nullptr*/) { return default; }
	public UObject CopyMeshSelectionToMesh(UObject TargetMesh,UObject StoreToSubmesh,FGeometryScriptMeshSelection Selection,UObject StoreToSubmeshOut,bool bAppendToExisting/*=false*/,bool bPreserveGroupIDs/*=false*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject CopyMeshToMesh(UObject CopyFromMesh,UObject CopyToMesh,UObject CopyToMeshOut,UObject Debug/*=nullptr*/) { return default; }
}
