#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCorePlaneRendererComponent.h")]
///<summary>A helper component that renders all the ARCore planes in the current tracking session.</summary>
public partial class UDEPRECATED_GoogleARCorePlaneRendererComponent : USceneComponent {
// GoogleARCorePlaneRendererComponent
	public bool bRenderPlane;
	public bool bRenderBoundaryPolygon;
	public FColor PlaneColor;
	public FColor BoundaryPolygonColor;
	public float BoundaryPolygonThickness;
}
