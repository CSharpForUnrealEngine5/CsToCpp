#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeRenderCaptureTool.h")]
public partial class UBakeRenderCaptureToolProperties : UInteractiveToolPropertySet {
// BakeRenderCaptureToolProperties
	public string MapPreview;
	public  TArray<string> GetMapPreviewNamesFunc() { return default; }
	public TArray<string> MapPreviewNamesList;
	public EBakeTextureSamplesPerPixel SamplesPerPixel;
	public EBakeTextureResolution TextureSize;
	public float ValidSampleDepthThreshold;
}
