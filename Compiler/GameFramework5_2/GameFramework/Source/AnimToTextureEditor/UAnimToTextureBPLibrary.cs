#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimToTextureBPLibrary.h")]
///<summary>* TODO:</summary>
public partial class UAnimToTextureBPLibrary : UBlueprintFunctionLibrary {
// AnimToTextureBPLibrary
	public void AnimationToTexture(UObject DataAsset,FTransform RootTransform,bool bSuccess) {}
	public UObject ConvertSkeletalMeshToStaticMesh(UObject SkeletalMesh,string PackageName,int LODIndex/*=-1*/) { return default; }
	public bool SetLightMapIndex(UObject StaticMesh,int LODIndex,int LightmapIndex/*=1*/,bool bGenerateLightmapUVs/*=true*/) { return default; }
	public void UpdateMaterialInstanceFromDataAsset(UObject DataAsset,UObject MaterialInstance,bool bAnimate/*=false*/,EAnimToTextureNumBoneInfluences NumBoneInfluences/*=EAnimToTextureNumBoneInfluences.One*/,EMaterialParameterAssociation MaterialParameterAssociation/*=EMaterialParameterAssociation.LayerParameter*/) {}
}
