namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBoneWeightFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBoneWeightFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether the TargetMesh has a per-vertex Bone/Skin Weight Attribute set</summary>
	public static UDynamicMesh MeshHasBoneWeights(UDynamicMesh TargetMesh,bool bHasBoneWeights,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	///<summary>Create a new BoneWeights attribute on the TargetMesh, if it does not already exist. If it does exist,</summary>
	public static UDynamicMesh MeshCreateBoneWeights(UDynamicMesh TargetMesh,bool bProfileExisted,bool bReplaceExistingProfile/*=false*/,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	///<summary>Determine the largest bone weight index that exists on the Mesh</summary>
	public static UDynamicMesh GetMaxBoneWeightIndex(UDynamicMesh TargetMesh,bool bHasBoneWeights,int MaxBoneIndex,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	///<summary>Return an array of Bone/Skin Weights at a given vertex of TargetMesh</summary>
	public static UDynamicMesh GetVertexBoneWeights(UDynamicMesh TargetMesh,int VertexID,TArray<FGeometryScriptBoneWeight> BoneWeights,bool bHasValidBoneWeights,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	///<summary>Return the Bone/Skin Weight with the maximum weight at a given vertex of TargetMesh</summary>
	public static UDynamicMesh GetLargestVertexBoneWeight(UDynamicMesh TargetMesh,int VertexID,FGeometryScriptBoneWeight BoneWeight,bool bHasValidBoneWeights,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	///<summary>Set the Bone/Skin Weights at a given vertex of TargetMesh</summary>
	public static UDynamicMesh SetVertexBoneWeights(UDynamicMesh TargetMesh,int VertexID,TArray<FGeometryScriptBoneWeight> BoneWeights,bool bIsValidVertexID,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	///<summary>Set all vertices of the TargetMesh to the given Bone/Skin Weights</summary>
	public static UDynamicMesh SetAllVertexBoneWeights(UDynamicMesh TargetMesh,TArray<FGeometryScriptBoneWeight> BoneWeights,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/) { return default; }
	///<summary>Computes a smooth skin binding for the given mesh to the skeleton provided.</summary>
	public static UDynamicMesh ComputeSmoothBoneWeights(UDynamicMesh TargetMesh,USkeleton Skeleton,FGeometryScriptSmoothBoneWeightsOptions Options,FGeometryScriptBoneWeightProfile Profile/*=new FGeometryScriptBoneWeightProfile()*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Transfer the bone weights from the SourceMesh to the TargetMesh. Assumes that the meshes are aligned. Otherwise,</summary>
	public static UDynamicMesh TransferBoneWeightsFromMesh(UDynamicMesh SourceMesh,UDynamicMesh TargetMesh,FGeometryScriptTransferBoneWeightsOptions Options/*=new FGeometryScriptTransferBoneWeightsOptions()*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Copy the bone attributes (skeleton) from the SourceMesh to the TargetMesh.</summary>
	public static UDynamicMesh CopyBonesFromMesh(UDynamicMesh SourceMesh,UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Discard the bone attributes (skeleton) from the TargetMesh.</summary>
	public static UDynamicMesh DiscardBonesFromMesh(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>GetBoneIndex</summary>
	public static UDynamicMesh GetBoneIndex(UDynamicMesh TargetMesh,FName BoneName,bool bIsValidBoneName,int BoneIndex,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Get the name of the root bone.</summary>
	public static UDynamicMesh GetRootBoneName(UDynamicMesh TargetMesh,FName BoneName,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Get the information about the children of the bone.</summary>
	public static UDynamicMesh GetBoneChildren(UDynamicMesh TargetMesh,FName BoneName,bool bRecursive,bool bIsValidBoneName,TArray<FGeometryScriptBoneInfo> ChildrenInfo,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Get the bone information.</summary>
	public static UDynamicMesh GetBoneInfo(UDynamicMesh TargetMesh,FName BoneName,bool bIsValidBoneName,FGeometryScriptBoneInfo BoneInfo,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Get an array of bones representing the skeleton. Each entry contains information about the bone.</summary>
	public static UDynamicMesh GetAllBonesInfo(UDynamicMesh TargetMesh,TArray<FGeometryScriptBoneInfo> BonesInfo,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
