namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool Result</summary>
[CppInclude("BakeRenderCaptureTool.h")]
public partial class UBakeRenderCaptureResults : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
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
