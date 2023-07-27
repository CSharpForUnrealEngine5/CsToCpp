#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeMapsTool.h")]
public partial class UBakeMeshAttributeMapsToolProperties : UInteractiveToolPropertySet {
// BakeMeshAttributeMapsToolProperties
	public int MapTypes;
	public string MapPreview;
	public EBakeTextureResolution Resolution;
	public EBakeTextureBitDepth BitDepth;
	public EBakeTextureSamplesPerPixel SamplesPerPixel;
	public UTexture2D SampleFilterMask;
	public  TArray<string> GetMapPreviewNamesFunc() { return default; }
	public TArray<string> MapPreviewNamesList;
}
