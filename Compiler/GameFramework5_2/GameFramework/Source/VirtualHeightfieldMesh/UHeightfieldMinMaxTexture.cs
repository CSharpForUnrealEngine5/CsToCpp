#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for a UTexture2D that can be built from a FHeightfieldMinMaxTextureBuildDesc description.</summary>
[CppInclude("HeightfieldMinMaxTexture.h")]
public partial class UHeightfieldMinMaxTexture : UObject {
	///<summary>The Height MinMax texture.</summary>
	public UTexture2D Texture;
	///<summary>A LodBias texture derived from the Height MinMax texture</summary>
	public UTexture2D LodBiasTexture;
	///<summary>A LodBias MinMax texture derived from the LodBias texture</summary>
	public UTexture2D LodBiasMinMaxTexture;
	///<summary>The number of mip levels to clone for CPU access.</summary>
	public int MaxCPULevels;
	///<summary>The raw MinMax data from the low resolution mip levels of Texture. These are CPU access of the MinMax bounds.</summary>
	public TArray<FVector2D> TextureData;
	///<summary>The size of the largest mip stored in TextureData.</summary>
	public FIntPoint TextureDataSize;
	///<summary>The starting array index for the data of each mip stored in TextureData.</summary>
	public TArray<int> TextureDataMips;
}
