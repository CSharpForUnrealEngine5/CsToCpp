#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility component for drawing a view frustum. Origin is at the component location, frustum points down position X axis.</summary>
[CppInclude("Components/DrawFrustumComponent.h")]
public partial class UDrawFrustumComponent : UPrimitiveComponent {
	///<summary>Enable or disable frustum visualization for this camera</summary>
	public bool bFrustumEnabled;
	///<summary>Color to draw the wireframe frustum.</summary>
	public FColor FrustumColor;
	///<summary>Angle of longest dimension of view shape.</summary>
	public float FrustumAngle;
	///<summary>Ratio of horizontal size over vertical size.</summary>
	public float FrustumAspectRatio;
	///<summary>Distance from origin to start drawing the frustum.</summary>
	public float FrustumStartDist;
	///<summary>Distance from origin to stop drawing the frustum.</summary>
	public float FrustumEndDist;
	///<summary>optional texture to show on the near plane</summary>
	public UTexture Texture;
}
