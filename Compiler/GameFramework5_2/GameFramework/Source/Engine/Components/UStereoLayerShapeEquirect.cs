#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StereoLayerComponent.h")]
public partial class UStereoLayerShapeEquirect : UStereoLayerShape {
// StereoLayerShapeEquirect
	public FBox2D LeftUVRect;
	public FBox2D RightUVRect;
	public FVector2D LeftScale;
	public FVector2D RightScale;
	public FVector2D LeftBias;
	public FVector2D RightBias;
	public  void SetEquirectProps(FEquirectProps InScaleBiases) {}
}
