namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/CollisionPropertySets.h")]
public partial class UCollisionGeometryVisualizationProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Show/hide collision geometry</summary>
	public bool bShowCollision;
	///<summary>Thickness of lines used to visualize collision shapes</summary>
	public float LineThickness;
	///<summary>Show occluded parts of the collision geometry, rendered with dashed lines</summary>
	public bool bShowHidden;
	///<summary>Render each collision geometry with a randomly-chosen color</summary>
	public bool bRandomColors;
	///<summary>The color to use for all collision visualizations, if random colors are not used</summary>
	public FColor Color;
	///<summary>LineMaterial</summary>
	public UMaterialInterface LineMaterial;
	///<summary>LineMaterialShowingHidden</summary>
	public UMaterialInterface LineMaterialShowingHidden;
	///<summary>bEnableShowCollision</summary>
	public bool bEnableShowCollision;
}
