#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/TextureFactory.h")]
public partial class UUDIMTextureFunctionLibrary : UBlueprintFunctionLibrary {
	///<summary>Make a UDIM virtual texture from a list of regular 2D textures</summary>
	public static UTexture2D MakeUDIMVirtualTextureFromTexture2Ds(string OutputPathName,TArray<UTexture2D> SourceTextures,TArray<FIntPoint> BlockCoords,bool bKeepExistingSettings/*=false*/,bool bCheckOutAndSave/*=false*/) { return default; }
}
