namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a series of animation frames into a Vertex Animation Texture (VAT)</summary>
[CppInclude("AnimToTextureBPLibrary.h")]
public partial class UAnimToTextureBPLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Bakes Animation Data into Textures.</summary>
	public static bool AnimationToTexture(UAnimToTextureDataAsset DataAsset) { return default; }
	///<summary>Utility for converting SkeletalMesh into a StaticMesh</summary>
	public static UStaticMesh ConvertSkeletalMeshToStaticMesh(USkeletalMesh SkeletalMesh,string PackageName,int LODIndex/*=-1*/) { return default; }
	///<summary>Utility for setting a StaticMesh LightMapIndex.</summary>
	public static bool SetLightMapIndex(UStaticMesh StaticMesh,int LODIndex,int LightmapIndex/*=1*/,bool bGenerateLightmapUVs/*=true*/) { return default; }
	///<summary>Updates a material&#39;s parameters to match those of an AnimToTexture DataAsset</summary>
	public static void UpdateMaterialInstanceFromDataAsset(UAnimToTextureDataAsset DataAsset,UMaterialInstanceConstant MaterialInstance,EMaterialParameterAssociation MaterialParameterAssociation/*=EMaterialParameterAssociation.LayerParameter*/) {}
}
