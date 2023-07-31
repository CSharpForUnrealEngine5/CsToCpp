#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A geometry layer within the stereo rendered viewport.</summary>
[CppInclude("Components/StereoLayerComponent.h")]
public partial class UStereoLayerComponent : USceneComponent {
	///<summary>Change the texture displayed on the stereo layer.</summary>
	public  void SetTexture(UTexture InTexture) {}
	///<summary>Change the texture displayed on the stereo layer for left eye, if stereoscopic layer textures are supported on the platform.</summary>
	public  void SetLeftTexture(UTexture InTexture) {}
	///<summary>@return the texture mapped to the stereo layer.</summary>
	public  UTexture GetTexture() { return default; }
	///<summary>@return the texture mapped to the stereo layer for left eye, if stereoscopic layer textures are supported on the platform.</summary>
	public  UTexture GetLeftTexture() { return default; }
	///<summary>Change the quad size. This is the unscaled height and width, before component scale is applied.</summary>
	public  void SetQuadSize(FVector2D InQuadSize) {}
	///<summary>@return the height and width of the rendered quad</summary>
	public  FVector2D GetQuadSize() { return default; }
	///<summary>Change the UV coordinates mapped to the quad face</summary>
	public  void SetUVRect(FBox2D InUVRect) {}
	///<summary>@return the UV coordinates mapped to the quad face</summary>
	public  FBox2D GetUVRect() { return default; }
	///<summary>Set Equirect layer properties: UVRect, Scale, and Bias</summary>
	public  void SetEquirectProps(FEquirectProps InScaleBiases) {}
	///<summary>Change the layer&#39;s render priority, higher priorities render on top of lower priorities</summary>
	public  void SetPriority(int InPriority) {}
	///<summary>@return the render priority</summary>
	public  int GetPriority() { return default; }
	///<summary>Manually mark the stereo layer texture for updating</summary>
	public  void MarkTextureForUpdate() {}
	///<summary>True if the stereo layer texture needs to update itself every frame(scene capture, video, etc.)</summary>
	public bool bLiveTexture;
	///<summary>True if the stereo layer needs to support depth intersections with the scene geometry, if available on the platform</summary>
	public bool bSupportsDepth;
	///<summary>True if the texture should not use its own alpha channel (1.0 will be substituted)</summary>
	public bool bNoAlphaChannel;
	///<summary>Texture displayed on the stereo layer (if stereoscopic textures are supported on the platform and more than one texture is provided, this will be the right eye) *</summary>
	public UTexture Texture;
	///<summary>Texture displayed on the stereo layer for left eye, if stereoscopic textures are supported on the platform and by the layer shape *</summary>
	public UTexture LeftTexture;
	///<summary>True if the quad should internally set it&#39;s Y value based on the set texture&#39;s dimensions</summary>
	public bool bQuadPreserveTextureRatio;
	///<summary>Size of the rendered stereo layer quad *</summary>
	public FVector2D QuadSize;
	///<summary>UV coordinates mapped to the quad face *</summary>
	public FBox2D UVRect;
	///<summary>CylinderRadius_DEPRECATED</summary>
	public float CylinderRadius_DEPRECATED;
	///<summary>CylinderOverlayArc_DEPRECATED</summary>
	public float CylinderOverlayArc_DEPRECATED;
	///<summary>CylinderHeight_DEPRECATED</summary>
	public int CylinderHeight_DEPRECATED;
	///<summary>EquirectProps_DEPRECATED</summary>
	public FEquirectProps EquirectProps_DEPRECATED;
	///<summary>Specifies how and where the quad is rendered to the screen *</summary>
	public EStereoLayerType StereoLayerType;
	///<summary>StereoLayerShape_DEPRECATED</summary>
	public EStereoLayerShape StereoLayerShape_DEPRECATED;
	///<summary>Specifies which shape of layer it is.  Note that some shapes will be supported only on certain platforms! *</summary>
	public UStereoLayerShape Shape;
	///<summary>Render priority among all stereo layers, higher priority render on top of lower priority *</summary>
	public int Priority;
}
