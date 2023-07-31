#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/GenerateStaticMeshLODAssetTool.h")]
public partial class UGenerateStaticMeshLODAssetToolTextureProperties : UInteractiveToolPropertySet {
	///<summary>Materials</summary>
	public TArray<FGenerateStaticMeshLOD_MaterialConfig> Materials;
	///<summary>Textures</summary>
	public TArray<FGenerateStaticMeshLOD_TextureConfig> Textures;
	///<summary>PreviewTextures</summary>
	public TArray<UTexture2D> PreviewTextures;
}
