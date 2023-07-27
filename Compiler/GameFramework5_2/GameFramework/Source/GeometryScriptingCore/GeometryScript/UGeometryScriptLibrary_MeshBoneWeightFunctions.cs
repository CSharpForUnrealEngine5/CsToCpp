#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBoneWeightFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBoneWeightFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshBoneWeightFunctions
	public static UDynamicMesh MeshHasBoneWeights(UDynamicMesh TargetMesh,bool bHasBoneWeights,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	public static UDynamicMesh MeshCreateBoneWeights(UDynamicMesh TargetMesh,bool bProfileExisted,bool bReplaceExistingProfile/*=false*/,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	public static UDynamicMesh GetMaxBoneWeightIndex(UDynamicMesh TargetMesh,bool bHasBoneWeights,int MaxBoneIndex,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	public static UDynamicMesh GetVertexBoneWeights(UDynamicMesh TargetMesh,int VertexID,TArray<FGeometryScriptBoneWeight> BoneWeights,bool bHasValidBoneWeights,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	public static UDynamicMesh GetLargestVertexBoneWeight(UDynamicMesh TargetMesh,int VertexID,FGeometryScriptBoneWeight BoneWeight,bool bHasValidBoneWeights,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	public static UDynamicMesh SetVertexBoneWeights(UDynamicMesh TargetMesh,int VertexID,TArray<FGeometryScriptBoneWeight> BoneWeights,bool bIsValidVertexID,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	public static UDynamicMesh SetAllVertexBoneWeights(UDynamicMesh TargetMesh,TArray<FGeometryScriptBoneWeight> BoneWeights,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	public static UDynamicMesh ComputeSmoothBoneWeights(UDynamicMesh TargetMesh,USkeleton Skeleton,FGeometryScriptSmoothBoneWeightsOptions Options,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
