namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* TODO:</summary>
[CppInclude("AnimToTextureBPLibrary.h")]
public partial class UAnimToTextureBPLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Bakes Animation Data into Textures.</summary>
	public static void AnimationToTexture(UAnimToTextureDataAsset DataAsset,FTransform RootTransform,bool bSuccess) {}
	///<summary>Utility for converting SkeletalMesh into a StaticMesh</summary>
	public static UStaticMesh ConvertSkeletalMeshToStaticMesh(USkeletalMesh SkeletalMesh,string PackageName,int LODIndex/*=-1*/) { return default; }
	///<summary>FIXME: you cannot set index to 2 if there is no index 1</summary>
	public static bool SetLightMapIndex(UStaticMesh StaticMesh,int LODIndex,int LightmapIndex/*=1*/,bool bGenerateLightmapUVs/*=true*/) { return default; }
	///<summary>Updates a material&#39;s parameters to match those of an animToTexture data asset</summary>
	public static void UpdateMaterialInstanceFromDataAsset(UAnimToTextureDataAsset DataAsset,UMaterialInstanceConstant MaterialInstance,bool bAnimate/*=false*/,EAnimToTextureNumBoneInfluences NumBoneInfluences/*=EAnimToTextureNumBoneInfluences.One*/,EMaterialParameterAssociation MaterialParameterAssociation/*=EMaterialParameterAssociation.LayerParameter*/) {}
}
