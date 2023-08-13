namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper component that renders all the ARCore planes in the current tracking session.</summary>
[CppInclude("GoogleARCorePlaneRendererComponent.h")]
public partial class UDEPRECATED_GoogleARCorePlaneRendererComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Render the plane quad when set to true.</summary>
	public bool bRenderPlane;
	///<summary>Render the plane boundary polygon lines when set to true.</summary>
	public bool bRenderBoundaryPolygon;
	///<summary>The color of the plane.</summary>
	public FColor PlaneColor;
	///<summary>The color of the boundary polygon.</summary>
	public FColor BoundaryPolygonColor;
	///<summary>The line thickness for the plan boundary polygon.</summary>
	public float BoundaryPolygonThickness;
}
