#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DrawFrustumComponent.h")]
///<summary>Utility component for drawing a view frustum. Origin is at the component location, frustum points down position X axis.</summary>
public partial class UDrawFrustumComponent : UPrimitiveComponent {
// DrawFrustumComponent
	public bool bFrustumEnabled;
	public FColor FrustumColor;
	public float FrustumAngle;
	public float FrustumAspectRatio;
	public float FrustumStartDist;
	public float FrustumEndDist;
	public UTexture Texture;
}
