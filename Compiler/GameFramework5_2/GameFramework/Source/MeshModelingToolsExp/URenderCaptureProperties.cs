#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeRenderCaptureTool.h")]
///<summary>Tool Properties</summary>
public partial class URenderCaptureProperties : UInteractiveToolPropertySet {
// RenderCaptureProperties
	public EBakeTextureResolution Resolution;
	public bool bBaseColorMap;
	public bool bNormalMap;
	public bool bPackedMRSMap;
	public bool bMetallicMap;
	public bool bRoughnessMap;
	public bool bSpecularMap;
	public bool bEmissiveMap;
	public bool bOpacityMap;
	public bool bSubsurfaceColorMap;
	public bool bAntiAliasing;
	public float CaptureFieldOfView;
	public float NearPlaneDist;
	public bool bDeviceDepthMap;
}
