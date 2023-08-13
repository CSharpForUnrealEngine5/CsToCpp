namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties for equirect layers</summary>
[CppInclude("Components/StereoLayerComponent.h")]
public partial struct FEquirectProps {
	public FBox2D LeftUVRect;
	public FBox2D RightUVRect;
	public FVector2D LeftScale;
	public FVector2D RightScale;
	public FVector2D LeftBias;
	public FVector2D RightBias;
}
