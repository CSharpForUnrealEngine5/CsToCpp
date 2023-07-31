#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool Result</summary>
[CppInclude("BakeRenderCaptureTool.h")]
public partial class UBakeRenderCaptureResults : UInteractiveToolPropertySet {
	///<summary>BaseColorMap</summary>
	public UTexture2D BaseColorMap;
	///<summary>World space normal map</summary>
	public UTexture2D NormalMap;
	///<summary>Packed Metallic/Roughness/Specular Map</summary>
	public UTexture2D PackedMRSMap;
	///<summary>MetallicMap</summary>
	public UTexture2D MetallicMap;
	///<summary>RoughnessMap</summary>
	public UTexture2D RoughnessMap;
	///<summary>SpecularMap</summary>
	public UTexture2D SpecularMap;
	///<summary>EmissiveMap</summary>
	public UTexture2D EmissiveMap;
	///<summary>OpacityMap</summary>
	public UTexture2D OpacityMap;
	///<summary>SubsurfaceColorMap</summary>
	public UTexture2D SubsurfaceColorMap;
}
