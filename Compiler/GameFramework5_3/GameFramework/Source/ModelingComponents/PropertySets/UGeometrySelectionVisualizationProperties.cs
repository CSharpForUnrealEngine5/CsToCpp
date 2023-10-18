namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertySets/GeometrySelectionVisualizationProperties.h")]
public partial class UGeometrySelectionVisualizationProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>This option should be enabled for tools in which the triangle color is reserved for some tool function.  The</summary>
	public bool bEnableShowTriangleROIBorder;
	///<summary>This option should be enabled for tools that treat edge selections as if they were vertex selections containing</summary>
	public bool bEnableShowEdgeSelectionVertices;
	///<summary>Geometry type of the geometry selection</summary>
	public EGeometrySelectionElementType SelectionElementType;
	///<summary>Topology type of the geometry selection</summary>
	public EGeometrySelectionTopologyType SelectionTopologyType;
	///<summary>Render the geometry selection</summary>
	public bool bShowSelection;
	///<summary>Render the geometry selection as the border of the triangles in the ROI (region of influence)</summary>
	public bool bShowTriangleROIBorder;
	///<summary>Show occluded parts of the selection</summary>
	public bool bShowHidden;
	///<summary>This tool treats edge selections as vertex selections. Enable this to show the edited vertices</summary>
	public bool bShowEdgeSelectionVertices;
	///<summary>Line thickness used to render the geometry selection</summary>
	public float LineThickness;
	///<summary>Point size used to render the geometry selection</summary>
	public float PointSize;
	///<summary>Depth bias used to slightly shift depth of points/lines</summary>
	public float DepthBias;
	///<summary>Color used to render the geometry selection</summary>
	public FColor FaceColor;
	///<summary>Color used to render the geometry selection</summary>
	public FColor LineColor;
	///<summary>Color used to render the geometry selection</summary>
	public FColor PointColor;
	///<summary>Color used to render the geometry selection ROI</summary>
	public FColor TriangleROIBorderColor;
	///<summary>Internal data/transient properties</summary>
	public UMaterialInterface TriangleMaterial;
	///<summary>LineMaterial</summary>
	public UMaterialInterface LineMaterial;
	///<summary>PointMaterial</summary>
	public UMaterialInterface PointMaterial;
	///<summary>TriangleMaterialShowingHidden</summary>
	public UMaterialInterface TriangleMaterialShowingHidden;
	///<summary>LineMaterialShowingHidden</summary>
	public UMaterialInterface LineMaterialShowingHidden;
	///<summary>PointMaterialShowingHidden</summary>
	public UMaterialInterface PointMaterialShowingHidden;
}
