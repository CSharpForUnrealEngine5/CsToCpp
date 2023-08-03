#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StereoLayerComponent.h")]
public partial class UStereoLayerShapeEquirect : UStereoLayerShape {
	public static UClass StaticClass() {return default;}
	///<summary>Left source texture UVRect, specifying portion of input texture corresponding to left eye.</summary>
	public FBox2D LeftUVRect;
	///<summary>Right source texture UVRect, specifying portion of input texture corresponding to right eye.</summary>
	public FBox2D RightUVRect;
	///<summary>Left eye&#39;s texture coordinate scale after mapping to 2D.</summary>
	public FVector2D LeftScale;
	///<summary>Right eye&#39;s texture coordinate scale after mapping to 2D.</summary>
	public FVector2D RightScale;
	///<summary>Left eye&#39;s texture coordinate bias after mapping to 2D.</summary>
	public FVector2D LeftBias;
	///<summary>Right eye&#39;s texture coordinate bias after mapping to 2D.</summary>
	public FVector2D RightBias;
	///<summary>Set Equirect layer properties: UVRect, Scale, and Bias</summary>
	public  void SetEquirectProps(FEquirectProps InScaleBiases) {}
}
