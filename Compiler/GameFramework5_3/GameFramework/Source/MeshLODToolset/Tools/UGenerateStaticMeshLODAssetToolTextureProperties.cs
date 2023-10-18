namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/GenerateStaticMeshLODAssetTool.h")]
public partial class UGenerateStaticMeshLODAssetToolTextureProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Materials</summary>
	public TArray<FGenerateStaticMeshLOD_MaterialConfig> Materials;
	///<summary>Textures</summary>
	public TArray<FGenerateStaticMeshLOD_TextureConfig> Textures;
	///<summary>PreviewTextures</summary>
	public TArray<UTexture2D> PreviewTextures;
}
