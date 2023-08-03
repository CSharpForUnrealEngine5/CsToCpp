#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/CollisionPropertySets.h")]
public partial class UCollisionGeometryVisualizationProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Thickness of lines used to visualize collision shapes</summary>
	public float LineThickness;
	///<summary>Show occluded parts of the collision geometry, rendered with dashed lines</summary>
	public bool bShowHidden;
	///<summary>Render each collision geometry with a randomly-chosen color</summary>
	public bool bRandomColors;
	///<summary>The color to use for all collision visualizations, if random colors are not used</summary>
	public FColor Color;
}
