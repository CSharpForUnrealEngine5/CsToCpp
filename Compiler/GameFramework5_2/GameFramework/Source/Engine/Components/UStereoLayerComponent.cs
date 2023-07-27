#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StereoLayerComponent.h")]
///<summary>A geometry layer within the stereo rendered viewport.</summary>
public partial class UStereoLayerComponent : USceneComponent {
// StereoLayerComponent
	public  void SetTexture(UTexture InTexture) {}
	public  void SetLeftTexture(UTexture InTexture) {}
	public  UTexture GetTexture() { return default; }
	public  UTexture GetLeftTexture() { return default; }
	public  void SetQuadSize(FVector2D InQuadSize) {}
	public  FVector2D GetQuadSize() { return default; }
	public  void SetUVRect(FBox2D InUVRect) {}
	public  FBox2D GetUVRect() { return default; }
	public  void SetEquirectProps(FEquirectProps InScaleBiases) {}
	public  void SetPriority(int InPriority) {}
	public  int GetPriority() { return default; }
	public  void MarkTextureForUpdate() {}
	public bool bLiveTexture;
	public bool bSupportsDepth;
	public bool bNoAlphaChannel;
	public UTexture Texture;
	public UTexture LeftTexture;
	public bool bQuadPreserveTextureRatio;
	public FVector2D QuadSize;
	public FBox2D UVRect;
	public float CylinderRadius_DEPRECATED;
	public float CylinderOverlayArc_DEPRECATED;
	public int CylinderHeight_DEPRECATED;
	public FEquirectProps EquirectProps_DEPRECATED;
	public byte StereoLayerType;
	public byte StereoLayerShape_DEPRECATED;
	public UStereoLayerShape Shape;
	public int Priority;
}
