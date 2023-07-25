#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeightfieldMinMaxTexture.h")]
///<summary>Container for a UTexture2D that can be built from a FHeightfieldMinMaxTextureBuildDesc description.</summary>
public partial class UHeightfieldMinMaxTexture : UObject {
// HeightfieldMinMaxTexture
	public UTexture2D Texture;
	public UTexture2D LodBiasTexture;
	public UTexture2D LodBiasMinMaxTexture;
	public int MaxCPULevels;
	public TArray<FVector2D> TextureData;
	public FIntPoint TextureDataSize;
	public TArray<int> TextureDataMips;
}
