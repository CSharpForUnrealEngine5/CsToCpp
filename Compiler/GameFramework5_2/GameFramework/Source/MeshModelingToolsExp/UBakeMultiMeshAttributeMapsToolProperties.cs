#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMultiMeshAttributeMapsTool.h")]
public partial class UBakeMultiMeshAttributeMapsToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>The map types to generate</summary>
	public int MapTypes;
	///<summary>The map type index to preview</summary>
	public string MapPreview;
	///<summary>The pixel resolution of the generated map</summary>
	public EBakeTextureResolution Resolution;
	///<summary>The channel bit depth of the source data for the generated textures</summary>
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
