#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimToTextureBPLibrary.h")]
///<summary>* TODO:</summary>
public partial class UAnimToTextureBPLibrary : UBlueprintFunctionLibrary {
// AnimToTextureBPLibrary
	public static void AnimationToTexture(UAnimToTextureDataAsset DataAsset,FTransform RootTransform,bool bSuccess) {}
	public static UStaticMesh ConvertSkeletalMeshToStaticMesh(USkeletalMesh SkeletalMesh,string PackageName,int LODIndex/*=-1*/) { return default; }
	public static bool SetLightMapIndex(UStaticMesh StaticMesh,int LODIndex,int LightmapIndex/*=1*/,bool bGenerateLightmapUVs/*=true*/) { return default; }
	public static void UpdateMaterialInstanceFromDataAsset(UAnimToTextureDataAsset DataAsset,UMaterialInstanceConstant MaterialInstance,bool bAnimate/*=false*/,EAnimToTextureNumBoneInfluences NumBoneInfluences/*=EAnimToTextureNumBoneInfluences.One*/,EMaterialParameterAssociation MaterialParameterAssociation/*=EMaterialParameterAssociation.LayerParameter*/) {}
}
