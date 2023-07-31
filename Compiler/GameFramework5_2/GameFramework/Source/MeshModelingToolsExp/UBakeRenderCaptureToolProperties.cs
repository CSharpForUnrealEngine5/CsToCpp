#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeRenderCaptureTool.h")]
public partial class UBakeRenderCaptureToolProperties : UInteractiveToolPropertySet {
	///<summary>The map type to preview</summary>
	public string MapPreview;
	///<summary>GetMapPreviewNamesFunc</summary>
	public  TArray<string> GetMapPreviewNamesFunc() { return default; }
	///<summary>MapPreviewNamesList</summary>
	public TArray<string> MapPreviewNamesList;
	///<summary>Number of samples per pixel</summary>
	public EBakeTextureSamplesPerPixel SamplesPerPixel;
	///<summary>Size of generated textures</summary>
	public EBakeTextureResolution TextureSize;
	///<summary>This threshold is used to detect occlusion artefacts (e.g., silhouettes/blotches in the base color) so that texels</summary>
	public float ValidSampleDepthThreshold;
}
