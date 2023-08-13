namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool Properties</summary>
[CppInclude("BakeRenderCaptureTool.h")]
public partial class URenderCaptureProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Resolution</summary>
	public EBakeTextureResolution Resolution;
	///<summary>Whether to generate a texture for the Base Color property</summary>
	public bool bBaseColorMap;
	///<summary>Whether to generate a texture for the World Normal property</summary>
	public bool bNormalMap;
	///<summary>Whether to generate a packed texture with Metallic, Roughness and Specular properties</summary>
	public bool bPackedMRSMap;
	///<summary>Whether to generate a texture for the Metallic property</summary>
	public bool bMetallicMap;
	///<summary>Whether to generate a texture for the Roughness property</summary>
	public bool bRoughnessMap;
	///<summary>Whether to generate a texture for the Specular property</summary>
	public bool bSpecularMap;
	///<summary>Whether to generate a texture for the Emissive property</summary>
	public bool bEmissiveMap;
	///<summary>Whether to generate a texture for the Opacity property</summary>
	public bool bOpacityMap;
	///<summary>Whether to generate a texture for the SubsurfaceColor property</summary>
	public bool bSubsurfaceColorMap;
	///<summary>Whether to use anti-aliasing in the render captures, this may introduce artefacts if pixels at different scene depths get blended</summary>
	public bool bAntiAliasing;
	///<summary>These are hidden in the UI right now, we might want to expose them if they turn out to be useful for very large</summary>
	public float CaptureFieldOfView;
	///<summary>NearPlaneDist</summary>
	public float NearPlaneDist;
	///<summary>bDeviceDepthMap</summary>
	public bool bDeviceDepthMap;
}
