#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeMapsTool.h")]
public partial class UBakeMeshAttributeMapsToolProperties : UInteractiveToolPropertySet {
	///<summary>The bake output types to generate</summary>
	public int MapTypes;
	///<summary>The baked output type used for preview in the viewport</summary>
	public string MapPreview;
	///<summary>The pixel resolution of the generated textures</summary>
	public EBakeTextureResolution Resolution;
	///<summary>The bit depth for each channel of the generated textures</summary>
	public EBakeTextureBitDepth BitDepth;
	///<summary>Number of samples per pixel</summary>
	public EBakeTextureSamplesPerPixel SamplesPerPixel;
	///<summary>Mask texture for filtering out samples/pixels from the output texture</summary>
	public UTexture2D SampleFilterMask;
	///<summary>GetMapPreviewNamesFunc</summary>
	public  TArray<string> GetMapPreviewNamesFunc() { return default; }
	///<summary>MapPreviewNamesList</summary>
	public TArray<string> MapPreviewNamesList;
}
